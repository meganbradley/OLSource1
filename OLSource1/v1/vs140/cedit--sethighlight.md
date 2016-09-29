---
title: "CEdit::SetHighlight"
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
  - "CEdit::SetHighlight"
  - "SetHighlight method"
  - "CEdit.SetHighlight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHighlight method"
ms.assetid: 67ebe9e7-fdb0-40a5-af95-f71770634261
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetHighlight
Highlights a range of text that is displayed in the current edit control.  
  
## Syntax  
  
```  
void SetHighlight(  
     int ichStart,   
     int ichEnd  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `ichStart`|Zero-based index of the first character in the range of text to highlight.|  
|[in] `ichEnd`|Zero-based index of the last character in the range of text to highlight.|  
  
## Remarks  
 This method sends the [EM_SETHILITE](http://msdn.microsoft.com/library/windows/desktop/bb761643) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::GetHighlight](../vs140/cedit--gethighlight.md)   
 [EM_SETHILITE](http://msdn.microsoft.com/library/windows/desktop/bb761643)