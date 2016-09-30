---
title: "Walkthrough: Using XSLT Hierarchy"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5e60c8ec-cd05-4597-b856-55038218acf4
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using XSLT Hierarchy
The XSLT Hierarchy tool simplifies many XML development tasks. An XSLT style sheet often uses <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instructions. Compilation starts from the principal style sheet, but when you see an error as a result of compiling an XSLT style sheet, the error may come from a different source than the principal style sheet. Fixing the error or editing the style sheet may require access to included or imported style sheets. Stepping through the style sheet in the debugger may open included and imported style sheets, and you may want to add a breakpoint at some point in one or more of the included style sheets.  
  
 Another scenario where the XSLT Hierarchy tool can be useful is putting breakpoints on the built-in template rules. Template rules are special templates generated for each mode of the style sheet and called by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when no other template matches the node. To implement debugging in built-in templates rules, XSLT debugger generates the file with the rules in the temporary folder and compiles them together with the principal style sheet. Without stepping into the code from some <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, it can be difficult to find style sheets that have been included in the principal style sheet or to find and open the style sheet with the built-in template rules.  
  
 The example in this topic demonstrates debugging in a referenced style sheet.  
  
### Procedure Title  
  
1.  Open an XML document in Visual Studio. This example uses the following <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> document.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Add the following <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Add the following <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> file:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Add a breakpoint at the instruction: <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
5.  Start debugging.  
  
6.  When the debugger stops at the instruction <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, press the step into button. Note that the debugging can be continued in the referenced style sheet. The hierarchy is visible and the designer displays the right path.  
  
## See Also  
 [Walkthrough: XSLT Profiler](../vs140/walkthrough--xslt-profiler.md)