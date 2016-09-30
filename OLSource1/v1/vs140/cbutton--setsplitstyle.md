---
title: "CButton::SetSplitStyle"
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
  - "CButton.SetSplitStyle"
  - "SetSplitStyle"
  - "CButton::SetSplitStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSplitStyle method"
ms.assetid: 95564f4b-af02-448a-b5e2-8f280dde1f6e
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetSplitStyle
Sets the style of the current split button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A bitwise combination of split button styles. For more information, see the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member of the [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure.|  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method only with controls whose button style is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The split button styles specify the alignment, aspect ratio, and graphical format with which Windows draws a split button icon. For more information, see the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of the [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure.  
  
 This method initializes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> flag and the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines the variable, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, that is used to programmatically access the split button control.  
  
 [!code[NVC_MFC_CButton_s1#1](../vs140/codesnippet/CPP/cbutton--setsplitstyle_1.h)]  
  
## Example  
 The following code example sets the style of the split button drop-down arrow. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> style displays the arrow on the left side of the button, and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> style retains the drop-down arrow's proportions when you resize the button.  
  
 [!code[NVC_MFC_CButton_s1#3](../vs140/codesnippet/CPP/cbutton--setsplitstyle_2.cpp)]  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetSplitStyle](../vs140/cbutton--getsplitstyle.md)   
 [CButton::GetSplitInfo](../vs140/cbutton--getsplitinfo.md)   
 [BCM_SETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775981)