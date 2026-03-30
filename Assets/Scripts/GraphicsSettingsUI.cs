using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class GraphicsSettingsUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Dropdown qualityDropdown;
    [SerializeField] private Dropdown resolutionDropdown;
    [SerializeField] private Toggle fullscreenToggle;

    private Resolution[] resolutions;
    private List<Resolution> filteredResolutions = new List<Resolution>();

    private void Start()
    {
        SetupQualityDropdown();
        SetupResolutionDropdown();
        LoadSettings();
    }

    // -----------------------
    // QUALITY
    // -----------------------
    private void SetupQualityDropdown()
    {
        qualityDropdown.ClearOptions();

        List<string> options = new List<string>(QualitySettings.names);
        qualityDropdown.AddOptions(options);

        int savedQuality = PlayerPrefs.GetInt("QualityLevel", QualitySettings.GetQualityLevel());
        qualityDropdown.value = savedQuality;

        QualitySettings.SetQualityLevel(savedQuality);

        qualityDropdown.onValueChanged.AddListener(SetQuality);
    }

    private void SetQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);

        PlayerPrefs.SetInt("QualityLevel", index);
        PlayerPrefs.Save();
    }

    // -----------------------
    // RESOLUTION
    // -----------------------
    private void SetupResolutionDropdown()
    {
        resolutions = Screen.resolutions;

        filteredResolutions = resolutions
            .GroupBy(r => new { r.width, r.height })
            .Select(g => g.First())
            .ToList();

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentIndex = 0;

        for (int i = 0; i < filteredResolutions.Count; i++)
        {
            var res = filteredResolutions[i];
            string label = res.width + " x " + res.height;
            options.Add(label);

            if (res.width == Screen.currentResolution.width &&
                res.height == Screen.currentResolution.height)
            {
                currentIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);

        int savedIndex = PlayerPrefs.GetInt("ResolutionIndex", currentIndex);
        resolutionDropdown.value = savedIndex;
        resolutionDropdown.RefreshShownValue();

        resolutionDropdown.onValueChanged.AddListener(SetResolution);
    }

    private void SetResolution(int index)
    {
        ApplyResolution(index);

        PlayerPrefs.SetInt("ResolutionIndex", index);
        PlayerPrefs.Save();
    }

    private void ApplyResolution(int index)
    {
        Resolution res = filteredResolutions[index];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

    // -----------------------
    // FULLSCREEN
    // -----------------------
    private void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;

        PlayerPrefs.SetInt("Fullscreen", isFullscreen ? 1 : 0);
        PlayerPrefs.Save();
    }

    // -----------------------
    // LOAD ALL SETTINGS
    // -----------------------
    private void LoadSettings()
    {
        // Fullscreen
        bool isFullscreen = PlayerPrefs.GetInt("Fullscreen", 1) == 1;
        Screen.fullScreen = isFullscreen;

        if (fullscreenToggle != null)
        {
            fullscreenToggle.isOn = isFullscreen;
            fullscreenToggle.onValueChanged.AddListener(SetFullscreen);
        }

        // Resolution (apply AFTER fullscreen)
        int resIndex = resolutionDropdown.value;
        ApplyResolution(resIndex);
    }

    private void OnDestroy()
    {
        qualityDropdown.onValueChanged.RemoveListener(SetQuality);
        resolutionDropdown.onValueChanged.RemoveListener(SetResolution);

        if (fullscreenToggle != null)
            fullscreenToggle.onValueChanged.RemoveListener(SetFullscreen);
    }
}