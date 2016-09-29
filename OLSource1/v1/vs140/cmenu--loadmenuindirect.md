---
title: "CMenu::LoadMenuIndirect"
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
  - "LoadMenuIndirect"
  - "CMenu.LoadMenuIndirect"
  - "CMenu::LoadMenuIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadMenuIndirect method"
  - "CMenu class, initialization"
ms.assetid: 8b25997d-6e70-4988-b324-4e381d3db124
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::LoadMenuIndirect
Loads a resource from a menu template in memory and attaches it to the `CMenu` object.  
  
## Syntax  
  
```  
  
      BOOL LoadMenuIndirect(  
   const void* lpMenuTemplate   
);  
```  
  
#### Parameters  
 *lpMenuTemplate*  
 Points to a menu template (which is a single [MENUITEMTEMPLATEHEADER](http://msdn.microsoft.com/library/windows/desktop/ms647583) structure and a collection of one or more [MENUITEMTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms647581) structures). For more information on these two structures, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if the menu resource was loaded successfully; otherwise 0.  
  
## Remarks  
 A menu template is a header followed by a collection of one or more [MENUITEMTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms647581) structures, each of which may contain one or more menu items and pop-up menus.  
  
 The version number should be 0.  
  
 The **mtOption** flags should include **MF_END** for the last item in a pop-up list and for the last item in the main list. See the `AppendMenu` member function for other flags. The **mtId** member must be omitted from the **MENUITEMTEMPLATE** structure when **MF_POPUP** is specified in **mtOption**.  
  
 The space allocated for the **MENUITEMTEMPLATE** structure must be large enough for **mtString** to contain the name of the menu item as a null-terminated string.  
  
 Before exiting, an application must free system resources associated with a menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](../vs140/cmenu--destroymenu.md) member function.  
  
## Example  
 [!code[NVC_MFCWindowing#30](../vs140/codesnippet/CPP/cmenu--loadmenuindirect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::DestroyMenu](../vs140/cmenu--destroymenu.md)   
 [CMenu::LoadMenu](../vs140/cmenu--loadmenu.md)   
 [LoadMenuIndirect](http://msdn.microsoft.com/library/windows/desktop/ms647991)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)