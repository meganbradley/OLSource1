---
title: "CTime::GetAsSystemTime"
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
  - "CTime.GetAsSystemTime"
  - "CTime::GetAsSystemTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAsSystemTime method"
ms.assetid: 544c79fd-12af-4c80-a83c-2a8909126fff
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetAsSystemTime
Call this member function to convert the time information stored in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to a Win32–compatible [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *timeDest*  
 A reference to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that will hold the converted date/time value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Return Value  
 True if successful; otherwise false.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> stores the resulting time in the referenced *timeDest* structure. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data structure initialized by this function will have its **wMilliseconds** member set to zero.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#151](../vs140/codesnippet/CPP/ctime--getassystemtime_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)