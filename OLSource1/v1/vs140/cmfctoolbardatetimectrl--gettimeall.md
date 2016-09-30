---
title: "CMFCToolBarDateTimeCtrl::GetTimeAll"
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
  - "CMFCToolBarDateTimeCtrl::GetTimeAll"
  - "GetTimeAll"
  - "CMFCToolBarDateTimeCtrl.GetTimeAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTimeAll method"
ms.assetid: 59d13f47-ef55-48dd-9862-551548abd439
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::GetTimeAll
Returns the time selected by the user from the time picker control button that has a specified command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a toolbar button's command ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the first overload, a [COleDateTime](../vs140/coledatetime-class.md) object that will receive the system time information. In the second overload, a [CTime](../vs140/ctime-class.md) object that will receive the system time information.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the system time information. Must not be <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If the framework cannot find a toolbar button that matches the command ID <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the return value is zero in the first overload, and GDT_NONE in the other overloads. If the toolbar button is found, the return value is the same as the return value from a call to [CMFCToolBarDateTimeCtrl::GetTime](../vs140/cmfctoolbardatetimectrl--gettime.md) on that button. A return value of zero or GDT_NONE can occur when the button is found, which indicates that the call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> did not return a valid date for some other reason.  
  
## Remarks  
 This method looks for a toolbar button that has the specified command ID and calls [CMFCToolBarDateTimeCtrl::GetTime](../vs140/cmfctoolbardatetimectrl--gettime.md) method on that button.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)