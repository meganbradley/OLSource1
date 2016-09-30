---
title: "CButton::SetNote"
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
  - "CButton::SetNote"
  - "CButton.SetNote"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetNote method"
  - "CButton.SetNote"
  - "CButton::SetNote"
ms.assetid: c7c7c31d-8ed9-436d-b23c-fcca516931c4
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetNote
Sets the note text for the current command link control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a Unicode string that is set as the note text for the command link control.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method only with controls whose button style is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 This method sends the [BCM_SETNOTE](http://msdn.microsoft.com/library/windows/desktop/bb775977) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, that is used to programmatically access the command link control. This variable is used in the following example.  
  
 [!code[NVC_MFC_CButton_s1#1](../vs140/codesnippet/CPP/cbutton--setnote_1.h)]  
  
## Example  
 The following code example sets the note text for the command link control.  
  
 [!code[NVC_MFC_CButton_s1#7](../vs140/codesnippet/CPP/cbutton--setnote_2.cpp)]  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetNote](../vs140/cbutton--getnote.md)   
 [CButton::GetNoteLength](../vs140/cbutton--getnotelength.md)   
 [BCM_SETNOTE](http://msdn.microsoft.com/library/windows/desktop/bb775977)