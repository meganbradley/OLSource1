---
title: "CReBarCtrl::GetExtendedStyle"
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
  - "CReBarCtrl.GetExtendedStyle"
  - "GetExtendedStyle method"
  - "CReBarCtrl::GetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedStyle method"
ms.assetid: 2f2284c2-946a-4c8f-a1a2-fc9cc803c65c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetExtendedStyle
Gets the extended styles of the current rebar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bitwise combination (OR) of flags that indicate the extended styles. The possible flags are <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter of the [CReBarCtrl::SetExtendedStyle](../vs140/crebarctrl--setextendedstyle.md) method.  
  
## Remarks  
 This method sends the [RB_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb774433) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RB_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb774433)   
 [CReBarCtrl::CreateEx](../vs140/crebarctrl--createex.md)