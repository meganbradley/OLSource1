---
title: "CDC::Escape"
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
  - "escape"
  - "CDC::Escape"
  - "CDC.Escape"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Escape method"
  - "CDC class, printer escape functions"
ms.assetid: 1e8a1228-d250-4200-acb0-f9c931d1a0ac
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Escape
This member function is practically obsolete for Win32 programming.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the escape function to be performed.  
  
 For a complete list of escape functions, see [Escape](http://msdn.microsoft.com/library/windows/desktop/dd162701) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the input data structure required for this escape.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to the structure that is to receive output from this escape. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is **NULL** if no data is returned.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to the input structure required for the specified escape.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Points to the structure that receives output from this escape. This parameter should be **NULL** if no data is returned.  
  
## Return Value  
 A positive value is returned if the function is successful, except for the **QUERYESCSUPPORT** escape, which only checks for implementation. Zero is returned if the escape is not implemented. A negative value is returned if an error occurred. The following are common error values:  
  
-   **SP_ERROR** General error.  
  
-   **SP_OUTOFDISK** Not enough disk space is currently available for spooling, and no more space will become available.  
  
-   **SP_OUTOFMEMORY** Not enough memory is available for spooling.  
  
-   **SP_USERABORT** User ended the job through the Print Manager.  
  
## Remarks  
 Of the original printer escapes, only **QUERYESCSUPPORT** is supported for Win32 applications. All other printer escapes are obsolete and are supported only for compatibility with 16-bit applications.  
  
 For Win32 programming, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> now provides six member functions that supersede their corresponding printer escapes:  
  
-   [CDC::AbortDoc](../vs140/cdc--abortdoc.md)  
  
-   [CDC::EndDoc](../vs140/cdc--enddoc.md)  
  
-   [CDC::EndPage](../vs140/cdc--endpage.md)  
  
-   [CDC::SetAbortProc](../vs140/cdc--setabortproc.md)  
  
-   [CDC::StartDoc](../vs140/cdc--startdoc.md)  
  
-   [CDC::StartPage](../vs140/cdc--startpage.md)  
  
 In addition, [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md) supports Win32 indexes that supersede other printer escapes. See [GetDeviceCaps](http://msdn.microsoft.com/library/windows/desktop/dd144877) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 This member function allows applications to access facilities of a particular device that are not directly available through GDI.  
  
 Use the first version if your application uses predefined escape values. Use the second version if your application defines private escape values. See [ExtEscape](http://msdn.microsoft.com/library/windows/desktop/dd162708) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about the second version.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ResetDC](../vs140/cdc--resetdc.md)   
 [EnumObjects](http://msdn.microsoft.com/library/windows/desktop/dd162685)