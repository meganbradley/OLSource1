---
title: "COleControlSite::ModifyStyleEx"
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
  - "COleControlSite.ModifyStyleEx"
  - "COleControlSite::ModifyStyleEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModifyStyleEx method"
  - "COleControlSite class, overridables"
ms.assetid: ebd74efd-0d5c-42f1-b6c9-f50ae1e2ef80
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::ModifyStyleEx
Modifies the extended styles of the control.  
  
## Syntax  
  
```  
  
      virtual BOOL ModifyStyleEx(  
   DWORD dwRemove,  
   DWORD dwAdd,  
   UINT nFlags   
);  
```  
  
#### Parameters  
 `dwRemove`  
 The extended styles to be removed from the current window styles.  
  
 `dwAdd`  
 The extended styles to be added from the current window styles.  
  
 `nFlags`  
 Window positioning flags. For a list of possible values, see the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if the styles are changed, otherwise zero.  
  
## Remarks  
 The control's stock Appearance property will be modified to match the setting for **WS_EX_CLIENTEDGE**. All other extended window styles are applied directly to the control's window handle, if one is present.  
  
 Modifies the window extended styles of the control site object. Styles to be added or removed can be combined by using the bitwise OR ( &#124; ) operator. See the [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about the available window styles.  
  
 If `nFlags` is nonzero, `ModifyStyleEx` calls the Win32 function `SetWindowPos`, and redraws the window by combining `nFlags` with the following four flags:  
  
-   `SWP_NOSIZE` Retains the current size.  
  
-   `SWP_NOMOVE` Retains the current position.  
  
-   `SWP_NOZORDER` Retains the current Z order.  
  
-   `SWP_NOACTIVATE` Does not activate the window.  
  
 To modify a window's extended styles, call [ModifyStyle](../vs140/colecontrolsite--modifystyle.md).  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)