---
title: "Tool Window Display Configuration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "tool windows, configuring"
  - "tool windows, appearance"
ms.assetid: 502a4926-bb83-473e-94e2-8e833c5f8b53
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Tool Window Display Configuration
When a VSPackage registers a tool window, the default position, size, docking style, and other visibility information is specified in optional values. For more information on tool window registration, see [Registering Tool Windows](../vs140/tool-windows-in-the-registry.md)  
  
## Window Display information  
 A tool window's basic display configuration is stored in up to six optional values:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|Name|REG_SZ|"Short name goes here"|A short name that describes the tool window. Used only for reference in the registry.|  
|Float|REG_SZ|"X1,Y1,X2,Y2"|Four comma separated values. X1, Y1 is the coordinate of the upper-left corner of the tool window. X2, Y2 is the coordinate of the lower-right corner. All values are in screen coordinates.|  
|Style|REG_SZ|"MDI"\<br />\<br /> "Float"\<br />\<br /> "Linked"\<br />\<br /> "Tabbed"\<br />\<br /> "AlwaysFloat"|A keyword specifying the initial display state of the tool window.\<br />\<br /> "MDI" = docked with MDI window.\<br />\<br /> "Float" = floating.\<br />\<br /> "Linked" = linked with another window (specified in the Window entry).\<br />\<br /> "Tabbed" = combined with another tool window.\<br />\<br /> "AlwaysFloat" = cannot be docked.\<br />\<br /> For more information, see the Comments section below.|  
|Window|REG_SZ|*\<GUID>*|The GUID of a window to which the tool window can be linked or tabbed. The GUID may belong to one of your own windows or one of the windows in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE.|  
|Orientation|REG_SZ|"Left"\<br />\<br /> "Right"\<br />\<br /> "Top"\<br />\<br /> "Bottom"|See the Comments section below.|  
|DontForceCreate|REG_DWORD|0 or 1|When this entry is present and its value is not zero, the window is loaded, but not immediately displayed.|  
  
### Comments  
 The Orientation entry defines the position where the tool window docks when its title bar is double-clicked. The position is relative to the window specified in the Window entry. If the Style entry is set to "Linked", the Orientation entry can be "Left", "Right", "Top", or "Bottom". If the Style entry is "Tabbed", the Orientation entry can be "Left" or "Right" and specifies where the tab is added. If the Style entry is "Float", the tool window floats first. When the title bar is double-clicked, the Orientation and Window entries apply, and the window uses the "Tabbed" style. If the Style entry is "AlwaysFloat", the tool window cannot be docked. If the Style entry is "MDI", the tool window is linked to the MDI area, and the Window entry is ignored.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Tool Window Visibility  
 Values in the optional Visibility subkey determine a tool window's visibility settings. The names of the values are used to store the GUIDs of commands that require the window's visibility. If the command is executed, the IDE guarantees that the tool window is created and made visible.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|(Default)|REG_SZ|None|Leave empty.|  
|*\<GUID>*|REG_DWORD or REG_SZ|0 or a descriptive string.|Optional. The entry's name must be the GUID of a command requiring visibility. The value just holds an informative string. Typically, the value is a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> set to 0.|  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Tool Window Essentials](../vs140/vspackage-essentials.md)