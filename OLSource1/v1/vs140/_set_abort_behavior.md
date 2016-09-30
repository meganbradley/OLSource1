---
title: "_set_abort_behavior"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_set_abort_behavior"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_set_abort_behavior"
  - "set_abort_behavior"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "aborting programs"
  - "_set_abort_behavior function"
  - "set_abort_behavior function"
ms.assetid: 43918766-e4ba-4b1f-80e8-1a4a910cd452
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_abort_behavior
Specifies the action to be taken when a program is abnormally terminated.  
  
> [!NOTE]
>  Do not use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function to shut down a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, except in testing or debugging scenarios. Programmatic or UI ways to close a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app are not permitted according to the [Windows 8 app certification requirements](http://go.microsoft.com/fwlink/?LinkId=262889). For more information, see [Application lifecycle (Windows Store apps)](http://go.microsoft.com/fwlink/?LinkId=262853).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New value of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flags.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Mask for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> flags bits to set.  
  
## Return Value  
 The old value of the flags.  
  
## Remarks  
 There are two <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> flags: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> determines whether a helpful text message is printed when a program is abnormally terminated. The message states that the application has called the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function. The default behavior is to print the message. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, if set, specifies that a Watson crash dump is generated and reported when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is called. By default, crash dump reporting is enabled in non-DEBUG builds.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Suppressing the abort message. If successful, this message will be the only output.**   
## See Also  
 [abort](../vs140/abort.md)