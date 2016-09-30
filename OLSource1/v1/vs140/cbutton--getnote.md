---
title: "CButton::GetNote"
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
  - "CButton::GetNote"
  - "GetNote"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNote method"
ms.assetid: b0db4c2d-871f-4bf6-a0ad-0a63a61d23d8
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::GetNote
Retrieves the note text associated with the current command link control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a buffer, which the caller is responsible for allocating and deallocating. If the return value is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the buffer contains the note text that is associated with the current command link control; otherwise, the buffer is unchanged.|  
|[in, out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A pointer to an unsigned integer variable.\<br />\<br /> When this method is called, the variable contains the size of the buffer specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> When this method returns, if the return value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> the variable contains the size of the note associated with the current command link control. If the return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the variable contains the buffer size required to contain the note.|  
  
## Return Value  
 In the first overload, a [CString](../vs140/using-cstring.md) object that contains the note text associated with the current command link control.  
  
 -or-  
  
 In the second overload, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method only with controls whose button style is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 This method sends the [BCM_GETNOTE](http://msdn.microsoft.com/library/windows/desktop/bb775965) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetNote](../vs140/cbutton--setnote.md)   
 [CButton::GetNoteLength](../vs140/cbutton--getnotelength.md)   
 [BCM_GETNOTE](http://msdn.microsoft.com/library/windows/desktop/bb775965)