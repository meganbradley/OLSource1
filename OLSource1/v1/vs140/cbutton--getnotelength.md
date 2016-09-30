---
title: "CButton::GetNoteLength"
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
  - "CButton::GetNoteLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNoteLength method"
ms.assetid: a324b9b4-164b-4023-8478-144e5fc85442
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetNoteLength
Retrieves the length of the note text for the current command link control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The length of the note text, in 16-bit Unicode characters, for the current command link control.  
  
## Remarks  
 Use this method only with controls whose button style is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 This method sends the [BCM_GETNOTELENGTH](http://msdn.microsoft.com/library/windows/desktop/bb775967) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetNote](../vs140/cbutton--getnote.md)   
 [CButton::SetNote](../vs140/cbutton--setnote.md)   
 [BCM_GETNOTELENGTH](http://msdn.microsoft.com/library/windows/desktop/bb775967)