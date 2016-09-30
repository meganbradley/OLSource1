---
title: "Walkthrough: Debug an XSLT Style Sheet"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3db9fa5a-f619-4cb6-86e7-64b364e58e5d
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Debug an XSLT Style Sheet
The steps in this walkthrough demonstrate how to use the XSLT debugger. Steps include viewing variables, setting breakpoints, and stepping through the code. The style sheet finds all books that cost below the average book price.  
  
### To prepare for this walkthrough  
  
1.  Close any open solutions.  
  
2.  Copy the two sample files to your local computer.  
  
## Start Debugging  
  
#### To start debugging  
  
1.  From the **File** menu, point to **Open**, and click **File**.  
  
2.  Locate the belowAvg.xsl file and click **Open**.  
  
     The style sheet is opened in the XML Editor.  
  
3.  Click the browse button (**...**) on the **Input** field of the document properties window.  
  
4.  Locate the books.xml file and click **Open**.  
  
     This sets the source document file that is used for the XSLT transformation.  
  
5.  Right-click the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> start tag, point to **Breakpoint**, and click **Insert Breakpoint**.  
  
6.  Click the **Debug XSL** button on the XML Editor toolbar.  
  
 This starts the debugging process and opens several new windows that are used by the debugger.  
  
 There are two windows that display the input document and styles sheet. The debugger uses these windows to show the current execution state. The debugger is positioned on the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element of the style sheet and on the first book node in the books.xml file.  
  
 The Locals window displays all the local variables and their current values. This includes variables defined in the style sheet and also variables that the debugger uses to track the nodes that are currently in context.  
  
 The **XSL Output** window displays the output of the XSL transformation. This window is separate from the **Visual Studio Output** window.  
  
## Watch Window  
  
#### To use the Watch window  
  
1.  From the **Debug** menu, point to **Windows**, point to **Watch**, and click **Watch 1**.  
  
     This makes the Watch 1 window visible.  
  
2.  Type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the **Name** field and press ENTER.  
  
     The value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable is displayed in the window.  
  
3.  Type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the **Name** field and press ENTER.  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an XPath expression that evaluates to the current context node. The value of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> XPath expression is the first book node. This changes as we progress through the transformation.  
  
4.  Expand the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> node, and then expand the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> node.  
  
     This allows you to see the value of the book price and you can easily compare it to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value. Because the book price is below the average, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> condition should succeed.  
  
## Step Through the Code  
 The debugger enables you to execute code one line at a time.  
  
#### To step through the code  
  
1.  Press **F5** to continue.  
  
     Because the first book node satisfied the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> condition, the book node is added to the XSL output window. The debugger continues to execute until it is positioned again on the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element in the style sheet. The debugger is now positioned on the second book node in the books.xml file.  
  
     In the Watch1 window the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value changes to the second book node. By examining the value of the price element, you can determine that the price is above the average, thus the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> condition should fail.  
  
2.  Press **F5** to continue.  
  
     Because the second book node does not meet the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> condition, the book node is not added to the XSL output window. The debugger continues to execute until it is positioned again on the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element in the style sheet. The debugger is now positioned on the third <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> node in the books.xml file.  
  
     In the Watch1 window the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value changes to the third book node. By examining the value of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element, you can determine that the price is below the average, thus the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> condition should succeed.  
  
3.  Press **F5** to continue.  
  
     Because the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> condition was satisfied, the third book is added to the XSL Output window. All books in the XML document have been processed and the debugger stops.  
  
## Sample Files  
 The following two files are used by the walkthrough.  
  
### belowAvg.xsl  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### books.xml  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Debugging XSLT](../vs140/debugging-xslt.md)