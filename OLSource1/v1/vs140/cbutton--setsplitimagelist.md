---
title: "CButton::SetSplitImageList"
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
  - "CButton::SetSplitImageList"
  - "CButton.SetSplitImageList"
  - "SetSplitImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSplitImageList method"
ms.assetid: 6dc5af83-5609-439b-8d4a-e28b3b99753e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetSplitImageList
Associates an [image list](../vs140/cimagelist-class.md) with the current split button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a [CImageList](../vs140/cimagelist-class.md) object to assign to the current split button control.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method only with controls whose button style is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 This method initializes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> flag and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetSplitImageList](../vs140/cbutton--getsplitimagelist.md)   
 [BCM_SETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775981)   
 [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955)   
 [CImageList Class](../vs140/cimagelist-class.md)