---
title: "CWinAppEx::EnableUserTools"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "EnableUserTools"
  - "CWinAppEx::EnableUserTools"
  - "CWinAppEx.EnableUserTools"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableUserTools method"
ms.assetid: 75b44d24-c7f7-4a9b-9ce7-174c47c10a41
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::EnableUserTools
Enables the user to create custom menu commands that reduce keystrokes in your application. This method creates a [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object.  
  
## Syntax  
  
```  
BOOL EnableUserTools(  
   const UINT uiCmdToolsDummy,  
   const UINT uiCmdFirst,  
   const UINT uiCmdLast,  
   CRuntimeClass* pToolRTC = RUNTIME_CLASS(CUserTool),  
   UINT uArgMenuID = 0,  
   UINT uInitDirMenuID = 0   
);  
```  
  
#### Parameters  
 [in] `uiCmdToolsDummy`  
 An unsigned integer that the framework uses as a placeholder for the command ID of the user tools menu.  
  
 [in] `uiCmdFirst`  
 The command ID for the first user tool command.  
  
 [in] `uiCmdLast`  
 The command ID for the last user tool command.  
  
 [in] `pToolRTC`  
 A class that the `CUserToolsManager` object uses to create new user tools.  
  
 [in] `uArgMenuID`  
 The argument menu ID.  
  
 [in] `uInitDirMenuID`  
 The menu ID for the initial tool directory.  
  
## Return Value  
 `TRUE` if the method creates and initializes a `CUserToolsManager` object; `FALSE` if the method fails or if a `CUserToolsManager` object already exists.  
  
## Remarks  
 When you enable user-defined tools, the framework automatically supports a dynamic menu that can be extended during customization. The framework associates each new item with an external command. The framework invokes these commands when the user selects the appropriate item from the **Tools** menu.  
  
 Every time the user adds a new item, the framework creates a new object. The class type for the new object is defined by `pToolRTC`. The `pToolRTC` class type must be derived from the [CUserTool Class](../vs140/cusertool-class.md).  
  
 For more information about user tools and how to incorporate them into your application, see [User-defined Tools](../vs140/user-defined-tools.md).  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)   
 [CUserTool Class](../vs140/cusertool-class.md)   
 [User-defined Tools](../vs140/user-defined-tools.md)