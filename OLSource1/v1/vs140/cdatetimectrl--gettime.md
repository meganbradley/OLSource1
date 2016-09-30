---
title: "CDateTimeCtrl::GetTime"
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
  - "CDateTimeCtrl::GetTime"
  - "CDateTimeCtrl.GetTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTime method"
ms.assetid: dac2f585-bd6a-4908-8556-8d7088efe4b2
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::GetTime
Retrieves the currently selected time from a date and time picker control and puts it in a specified <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *timeDest*  
 In the first version, a reference to a [COleDateTime](../vs140/coledatetime-class.md) object that will receive the system time information. In the second version, a reference to a [CTime](../vs140/ctime-class.md) object that will receive the system time information.  
  
 *pTimeDest*  
 A pointer to the [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the system time information. Must not be **NULL**.  
  
## Return Value  
 In the first version, nonzero if the time is successfully written to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object; otherwise 0. In the second and third versions, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value equal to the **dwFlag** member set in the [NMDATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761730) structure. See the **Remarks** section below for more information.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_GETSYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/bb761769), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In the MFC implementation of **GetTime**, you can use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> classes, or you can use a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure, to store the time information.  
  
 The return value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the second and third versions, above, indicates whether or not the date and time picker control is set to the "no date" status, as indicated in the [NMDATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761730) structure member <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If the value returned equals **GDT_NONE**, the control is set to "no date" status, and uses the **DTS_SHOWNONE** style. If the value returned equals **GDT_VALID**, the system time is successfully stored in the destination location.  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#5](../vs140/codesnippet/CPP/cdatetimectrl--gettime_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::SetTime](../vs140/cdatetimectrl--settime.md)