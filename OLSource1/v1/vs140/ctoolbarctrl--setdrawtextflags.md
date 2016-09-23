---
title: "CToolBarCtrl::SetDrawTextFlags"
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
  - CToolBarCtrl::SetDrawTextFlags
  - CToolBarCtrl.SetDrawTextFlags
  - SetDrawTextFlags
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDrawTextFlags method
ms.assetid: 2b826f57-a0a4-4054-a1b5-b8b005cd93be
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::SetDrawTextFlags
Sets the flags in the Win32 function [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498), which is used to draw the text in the specified rectangle, formatted according to how the flags are set.  
  
## Syntax  
  
```  
  
      DWORD SetDrawTextFlags(  
   DWORD dwMask,  
   DWORD dwDTFlags   
);  
```  
  
#### Parameters  
 `dwMask`  
 A combination of one or more of the DT_ flags, specified in the Win32 function [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498), that indicates which bits in `dwDTFlags` will be used when drawing the text.  
  
 `dwDTFlags`  
 A combination of one or more of the DT_ flags, specified in the Win32 function `DrawText`, that indicate how the button text will be drawn. This value is passed to `DrawText` when the button text is drawn.  
  
## Return Value  
 A `DWORD` containing the previous text drawing flags.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETDRAWTEXTFLAGS](http://msdn.microsoft.com/library/windows/desktop/bb787425), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This member function sets the flags in the Win32 function `DrawText`, which draws text in the specified rectangle, formatted according to how the flags are set.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)