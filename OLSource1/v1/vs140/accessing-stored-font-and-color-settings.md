---
title: "Accessing Stored Font and Color Settings"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - fonts, accessing stored settings
  - font and color control [Visual Studio SDK], persistence
  - colors, accessing stored settings
ms.assetid: beba7174-e787-45c2-b6ff-a60f67ad4998
caps.latest.revision: 30
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Accessing Stored Font and Color Settings
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE) stores modified settings for fonts and colors in the registry. You can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> interface to access these settings.  
  
## To Initiate State Persistence of Fonts and Colors  
 Font and color information is stored by category in the following registry location: [HKCU\SOFTWARE\Microsoft \Visual Studio\\*<Visual Studio version\>*\FontAndColors\\*<CategoryGUID\>*], where *<CategoryGUID\>* is the category GUID.  
  
 Therefore, to initiate persistence, a VSPackage must:  
  
-   Obtain an <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> interface by calling `QueryService` against the global service provider.  
  
     `QueryService` must be called by using a service ID argument of `SID_SVsFontAndColorStorage` and an interface ID argument of `IID_IVsFontAndColorStorage`.  
  
-   Use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.OpenCategory?qualifyHint=False> method to open a category to be persisted by using the category's GUID and a mode flag as arguments.  
  
     The mode, specified by the `fFlags` argument, is constructed from values in the <xref:Microsoft.VisualStudio.Shell.Interop.__FCSTORAGEFLAGS?qualifyHint=False> enumeration. This mode controls:  
  
    -   The settings that can be accessed through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> interface.  
  
    -   Either all settings or only those that users modify and that are retrievable through the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> interface.  
  
    -   The manner of propagating the changes to user settings.  
  
    -   The format of color values that are used.  
  
## To Use State Persistence of Fonts and Colors  
 Persisting fonts and colors involves:  
  
-   Synchronizing the IDE settings with settings stored in the registry.  
  
-   Propagating registry modification information.  
  
-   Setting and retrieving settings stored in the registry.  
  
 Synchronizing the storage setting with the IDE settings is largely transparent. The underlying IDE automatically writes updated settings for **Display Items** to the registry entries of categories.  
  
 If multiple VSPackages share a particular category, a VSPackage should require that events are generated when methods of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> interface are used to modify stored registry settings.  
  
 By default, event generation is not enabled. To enable event generation, a category must be opened by using <xref:Microsoft.VisualStudio.Shell.Interop.__FCSTORAGEFLAGS.FCSF_PROPAGATECHANGES?qualifyHint=False>. This causes the IDE to call the appropriate <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorEvents?qualifyHint=False> method that a VSPackage implements.  
  
> [!NOTE]
>  Modifications through the **Font and Color** property page generate events independent of <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False>. You can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorCacheManager?qualifyHint=False> interface to determine whether an update of cached font and color settings is needed before calling the methods of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> class.  
  
### Storing and Retrieving Information  
 To obtain or configure information that a user can modify for a named display item in an open category, VSPackages call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetItem?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.SetItem?qualifyHint=False> methods.  
  
 Information about font attributes for a particular category is obtained by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetFont?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.SetFont?qualifyHint=False> methods.  
  
> [!NOTE]
>  The `fFlags` argument that is passed to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.OpenCategory?qualifyHint=False> method when that category was opened defines the behavior of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetItem?qualifyHint=False> and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetFont?qualifyHint=False> methods. By default, these methods only return information aboutdisplay itemsthat have changed. However, if a category is opened by using the <xref:Microsoft.VisualStudio.Shell.Interop.__FCSTORAGEFLAGS.FCSF_LOADDEFAULTS?qualifyHint=False> flag, both updated and unchanged display items can be accessed by <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetItem?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetFont?qualifyHint=False>.  
  
 By default, only changed **Display Items** information is kept in the registry. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False> interface cannot be used to retrieve all settings for fonts and colors.  
  
> [!NOTE]
>  The <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetItem?qualifyHint=False> and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage.GetFont?qualifyHint=False> methods return REGDB_E_KEYMISSING, (0x80040152L) when you use them to retrieve information about unchanged **Display Items**.  
  
 The settings of all **Display Items** in a particular **Category** can be obtained by using the methods of the `T:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorDefaults` interface.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsFontAndColorStorage?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.Shell.Interop.__FCSTORAGEFLAGS?qualifyHint=False>   
 [How to: Implement Custom Categories and Display Items](../vs140/implementing-custom-categories-and-display-items.md)