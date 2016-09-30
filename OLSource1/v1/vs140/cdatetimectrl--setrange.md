---
title: "CDateTimeCtrl::SetRange"
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
  - "CDateTimeCtrl::SetRange"
  - "CDateTimeCtrl.SetRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRange method"
ms.assetid: a49db990-772c-41c9-b2d3-4373f70d32c9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::SetRange
Sets the minimum and maximum allowed system times for a date and time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [COleDateTime](../vs140/coledatetime-class.md) object or a [CTime](../vs140/ctime-class.md) object containing the earliest time allowed in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object containing the latest time allowed in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_SETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761780), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation, you can specify either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> usages. If the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object has a **NULL** status, the range will be removed. If the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer or the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pointer is **NULL**, the range will be removed.  
  
## Example  
 See the example for [CDateTimeCtrl::GetRange](../vs140/cdatetimectrl--getrange.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::GetRange](../vs140/cdatetimectrl--getrange.md)