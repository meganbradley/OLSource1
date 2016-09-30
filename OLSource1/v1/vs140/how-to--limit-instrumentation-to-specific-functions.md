---
title: "How to: Limit Instrumentation to Specific Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "performance tools, limiting instrumentation to functions"
ms.assetid: bd98d6bf-2560-4eba-b063-2facb09f87c4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Limit Instrumentation to Specific Functions
You can limit instrumentation and data collection to one or more functions by setting options in the **Advanced** page of the **Performance Session** or target binary property pages:  
  
-   If you specify the functions on the performance session property page, only those functions are instrumented in all instrumented binaries of the session.  
  
-   If you specify the functions on the property page of a target binary, only those functions that are in that particular binary are instrumented. Functions in other binaries of the performance are instrumented as usual.  
  
 Limiting data collection in this manner is supported only when the instrumentation profiling method is selected.  
  
> [!NOTE]
>  You can also use the **Advanced** page of the **Performance Session** property pages to set other options that are available to the Profiling Tools [VSInstr](../vs140/vsinstr.md) command line instrumentation tool.  
  
### To limit instrumentation to specific functions in a performance session  
  
1.  In **Performance Explorer**, right-click the session name and then click **Properties**.  
  
     The **Property Pages** dialog box is displayed.  
  
2.  On the **Property Pages** dialog box, click **Advanced**.  
  
3.  In the **Additional instrumentation options** text box, use the following syntax to type the name of the functions that you want to instrument:  
  
     **/include:** <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> **[;** <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> **]** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the namespace and function name. It has the format <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>**::**<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Use a semicolon to separate multiple functions. Use an asterisk (\*) to specify a wildcard for one or more characters. For example, **/include:MyNS::\*** specifies all functions in the MyNS namespace.  
  
    > [!NOTE]
    >  To list the functions in a binary, open a command prompt window in the Profiling Tools installation directory (typically, the \Team Tools\Performance Tools directory under the [!INCLUDE[vsprvsts](../vs140/includes/vsprvsts_md.md)] installation directory) and then type **vsinstr /DumpFuncs**  
  
### To limit instrumentation to specific functions in a binary  
  
1.  In **Performance Explorer**, locate the binary name in the **Targets** node of the performance session.  
  
2.  Right-click the binary name and then click **Properties**.  
  
     The **Property Pages** dialog box is displayed.  
  
3.  On the **Property Pages** dialog box, click **Advanced**.  
  
4.  In the **Additional instrumentation options** text box, use the following syntax to type the name of the functions that you want to instrument:  
  
     **/include:** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **[;** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **]** <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the namespace and function name. It has the format <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>**::**<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Use a semicolon to separate multiple functions. Use an asterisk (\*) to specify a wildcard for one or more characters. For example, **/include:MyNS::\*** specifies all functions in the MyNS namespace.  
  
    > [!NOTE]
    >  To list the functions in a binary, open a command prompt window in the Profiling Tools installation directory (typically, the \Team Tools\Performance Tools directory under the [!INCLUDE[vsprvsts](../vs140/includes/vsprvsts_md.md)] installation directory) and then type **vsinstr /DumpFuncs**  
  
## See Also  
 [Controlling Data Collection](../vs140/controlling-data-collection.md)   
 [How to: Limit Instrumentation to Specific DLLs](../vs140/how-to--limit-instrumentation-to-specific-dlls.md)   
 [How to: Specify Additional Instrumentation Options](../vs140/how-to--specify-additional-instrumentation-options.md)