---
title: "CDateTimeCtrl::SetMonthCalFont"
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
  - "CDateTimeCtrl.SetMonthCalFont"
  - "SetMonthCalFont"
  - "CDateTimeCtrl::SetMonthCalFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMonthCalFont method"
ms.assetid: aec0494a-040b-4a11-98ea-2992820c3575
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::SetMonthCalFont
Sets the font that the date and time picker control's child month calendar control will use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the font that will be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether the control should be redrawn immediately upon setting the font. Setting this parameter to **TRUE** causes the control to redraw itself.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_SETMCFONT](http://msdn.microsoft.com/library/windows/desktop/bb761775), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#7](../vs140/codesnippet/CPP/cdatetimectrl--setmonthcalfont_1.cpp)]  
  
> [!NOTE]
>  If you use this code, you'll want to make a member of your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived class called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of type **CFont**.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::GetMonthCalFont](../vs140/cdatetimectrl--getmonthcalfont.md)