using PKHeX.Core;

namespace PluginPile.SVProfilePictureViewer {
  internal static class Language {
    public static string CurrentProfilePicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "当前个人简介照片",
          "it"      => "Foto Profilo Attuale",
          "en" or _ => "Current Profile Picture"
        };
      }
    }

    public static string CurrentProfileIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "当前训练家头像",
          "it"      => "Icona Profilo Corrente",
          "en" or _ => "Current Profile Icon"
        };
      }
    }

    public static string InitialProfilePicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "初始个人简介照片",
          "it"      => "Foto Profilo Iniziale",
          "en" or _ => "Initial Profile Picture"
        };
      }
    }

    public static string InitialProfileIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "初始训练家头像",
          "it"      => "Icona Profilo Iniziale",
          "en" or _ => "Initial Profile Icon"
        };
      }
    }

    public static string PluginName {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "个人简介照片查看器",
          "it"      => "Visualizzatore Foto Profilo",
          "en" or _ => "Profile Picture Viewer"
        };
      }
    }

    public static string Export {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "导出",
          "it"      => "Esporta",
          "en" or _ => "Export"
        };
      }
    }
    public static string ImportTitle {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "选择一张图片作为您的个人简介照片或训练家头像",
          "it"      => "Seleziona Immagine per foto/icona",
          "en" or _ => "Select Image for picture/icon"
        };
      }
    }
    public static string ImportCurrentPicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "导入当前图片",
          "en" or _ => "Import Current Picture"
        };
      }
    }
    public static string ImportCurrentIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "导入当前头像",
          "en" or _ => "Import Current Icon"
        };
      }
    }
    public static string ImportInitialPicture {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "导入初始图片",
          "en" or _ => "Import Initial Picture"
        };
      }
    }
    public static string ImportInitialIcon {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "导入初始头像",
          "en" or _ => "Import Initial Icon"
        };
      }
    }
    public static string ImportWarning {
      get {
        return GameInfo.CurrentLanguage switch {
          "zh"      => "此功能为实验性功能，合法性不保证，修改后建议不要联网，以免被ban.",
          "it"      => "Questa funzione è a scopo sperimentale, la qualità non è garantita ed è raccomandato non andare online con tali modifiche onde evitare ban.",
          "en" or _ => "This is an experimental function, quality is not guaranteed and it is recommended to not go online with these modifications, in order to avoid ban."
        };
      }
    }
  }
}
