---
title: "CEdit::ShowBalloonTip"
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
  - "CEdit::ShowBalloonTip"
  - "ShowBalloonTip method"
  - "CEdit.ShowBalloonTip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowBalloonTip method"
ms.assetid: 8b3cbae5-b7c0-48d0-b244-9215b73a6fc3
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::ShowBalloonTip
Displays a balloon tip that is associated with the current edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to an [EDITBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb775466) structure that describes the balloon tip.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Pointer to a Unicode string that contains the title of the balloon tip.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Pointer to a Unicode string that contains the balloon tip text.|  
|[in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that specifies the type of icon to associate with the balloon tip. The default value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For more information, see the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of the [EDITBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb775466) structure.|  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function sends the [EM_SHOWBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb761668) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see the [Edit_ShowBalloonTip](http://msdn.microsoft.com/library/windows/desktop/bb761707) macro.  
  
## Example  
 The following code example defines a variable, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, that is used to access the current edit control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CEdit_s1#1](../vs140/codesnippet/CPP/cedit--showballoontip_1.h)]  
  
## Example  
 The following code example displays a balloon tip for an edit control. The [CEdit::ShowBalloonTip](../vs140/cedit--showballoontip.md) method specifies a title and balloon tip text.  
  
 [!code[NVC_MFC_CEdit_s1#3](../vs140/codesnippet/CPP/cedit--showballoontip_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::HideBalloonTip](../vs140/cedit--hideballoontip.md)   
 [EM_SHOWBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb761668)   
 [EDITBALLOONTIP](http://msdn.microsoft.com/library/windows/desktop/bb775466)   
 [Edit_ShowBalloonTip](http://msdn.microsoft.com/library/windows/desktop/bb761707)