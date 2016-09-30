---
title: "CComboBox::GetCueBanner"
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
  - "CCombobox::GetCueBanner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCueBanner method"
ms.assetid: 308b9c92-8e70-43cc-ae14-b1904362d270
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetCueBanner
Gets the cue text that is displayed for a combo box control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a buffer that receives the cue banner text.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Size of the buffer that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter points to.|  
  
## Return Value  
 In the first overload, a [CString](../vs140/using-cstring.md) object that contains the cue banner text if it exists; otherwise, a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that has zero length.  
  
 -or-  
  
 In the second overload, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 Cue text is a prompt that is displayed in the input area of the combo box control. The cue text is displayed until the user provides input.  
  
 This method sends the [CB_GETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb775843) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetCueBanner](../vs140/ccombobox--setcuebanner.md)   
 [CB_GETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb775843)