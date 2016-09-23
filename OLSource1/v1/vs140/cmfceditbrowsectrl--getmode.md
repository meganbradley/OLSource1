---
title: "CMFCEditBrowseCtrl::GetMode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCEditBrowseCtrl::GetMode
  - CMFCEditBrowseCtrl.GetMode
  - GetMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMode method
  - edit browse modes
ms.assetid: 66a10e87-b3ed-4b20-896d-e3dbe39d775e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCEditBrowseCtrl::GetMode
Retrieves the browse mode of the current edit browse control.  
  
## Syntax  
  
```  
CMFCEditBrowseCtrl::BrowseMode GetMode() const;  
```  
  
## Return Value  
 One of the enumeration values that specifies the current mode of the edit browse control. The browse mode determines whether the framework displays the browse button and what action occurs when a user clicks that button.  
  
 The following table lists the possible return values.  
  
|Value|Description|  
|-----------|-----------------|  
|`BrowseMode_Default`|`custom mode`. A programmer-defined action is performed.|  
|`BrowseMode_File`|`file mode`. The standard file browser dialog box is displayed.|  
|`BrowseMode_Folder`|`folder mode`. The standard folder browser dialog box is displayed.|  
|`BrowseMode_None`|The browse button is not displayed.|  
  
## Remarks  
 By default, a `CMFCEditBrowseCtrl` object is initialized to `BrowseMode_None` mode. Modify the browse mode with the [CMFCEditBrowseCtrl::EnableBrowseButton](../vs140/cmfceditbrowsectrl--enablebrowsebutton.md), [CMFCEditBrowseCtrl::EnableFileBrowseButton](../vs140/cmfceditbrowsectrl--enablefilebrowsebutton.md), and [CMFCEditBrowseCtrl::EnableFolderBrowseButton](../vs140/cmfceditbrowsectrl--enablefolderbrowsebutton.md) methods.  
  
## Requirements  
 **Header:** afxeditbrowsectrl.h  
  
## See Also  
 [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCEditBrowseCtrl::EnableBrowseButton](../vs140/cmfceditbrowsectrl--enablebrowsebutton.md)   
 [CMFCEditBrowseCtrl::EnableFileBrowseButton](../vs140/cmfceditbrowsectrl--enablefilebrowsebutton.md)   
 [CMFCEditBrowseCtrl::EnableFolderBrowseButton](../vs140/cmfceditbrowsectrl--enablefolderbrowsebutton.md)   
 [CMFCEditBrowseCtrl::OnBrowse](../vs140/cmfceditbrowsectrl--onbrowse.md)