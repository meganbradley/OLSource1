---
title: "How to: Evaluate an XPath Expression"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 159ba4ef-75e4-4ac8-80dc-e064e0bec345
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Evaluate an XPath Expression
You can evaluate XPath expressions with the **QuickWatch** dialog box. The XPath expression must be valid according to the W3C XPath 1.0 recommendation. The current XSLT context—that is, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> node in the **Locals** window—provides the evaluation context for the XPath expression.  
  
 The following list describes which functions are supported when evaluating an XPath expression:  
  
-   Built-in XPath functions are supported.  
  
-   Built-in XSLT functions are not supported.  
  
-   User-defined functions are not supported.  
  
> [!NOTE]
>  The following procedure uses the belowAvg.xsl and books.xml files from the [Walkthrough: Debug an XSLT Style Sheet](../vs140/walkthrough--debug-an-xslt-style-sheet.md) topic.  
  
### To evaluate an XPath expression  
  
1.  Insert a breakpoint at the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> start tag.  
  
2.  Click the **Debug XSL** button on the XML Editor toolbar.  
  
     The debugger starts and breaks on the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> tag.  
  
3.  Right-click and select **QuickWatch**.  
  
     The **QuickWatch** dialog box is displayed.  
  
4.  Enter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the **Expression** field of the **QuickWatch** dialog box and click **Reevaluate**.  
  
     The price of the current book node appears in the **Value** box.  
  
5.  Change the XPath expression to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and click **Reevaluate**.  
  
     The **Value** box shows that the XPath expression evaluates to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 [Debugging XSLT](../vs140/debugging-xslt.md)