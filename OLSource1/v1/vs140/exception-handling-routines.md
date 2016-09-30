---
title: "Exception Handling Routines"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.exceptions"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "exception handling, routines"
ms.assetid: f60548c6-850a-4e1e-a79b-a2a6a541ab62
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exception Handling Routines
Use the C++ exception-handling functions to recover from unexpected events during program execution.  
  
### Exception-Handling Functions  
  
|Function|Use|.NET Framework equivalent|  
|--------------|---------|-------------------------------|  
|[_set_se_translator](../vs140/_set_se_translator.md)|Handle Win32 exceptions (C structured exceptions) as C++ typed exceptions|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[set_terminate](../vs140/set_terminate--crt-.md)|Install your own termination routine to be called by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[set_unexpected](../vs140/set_unexpected--crt-.md)|Install your own termination function to be called by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[terminate](../vs140/terminate--crt-.md)|Called automatically under certain circumstances after exception is thrown. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or a function you specify using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[unexpected](../vs140/unexpected--crt-.md)|Calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or a function you specify using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function is not used in current Microsoft C++ exception-handling implementation|[System::Exception Class](https://msdn.microsoft.com/en-us/library/system.exception.aspx)|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)