---
title: "Walkthrough: Implementing IEnumerable(Of T) in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "control flow [Visual Basic]"
  - "enumerable interfaces"
  - "loop structures, optimizing performance"
  - "control flow"
ms.assetid: c60d7589-51f2-4463-a2d5-22506bbc1554
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Implementing IEnumerable(Of T) in Visual Basic
The <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>IEnumerable(T)<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*> interface to expose source data as enumerable data. Your class that implements the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface will require another class that implements the <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>IEnumerable(Of String)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>IEnumerator(Of String)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>StreamReaderEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>StreamReaderEnumerable.vb<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>StreamReaderEnumerable<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>IEnumerable(Of String)<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>StreamReaderEnumerator.vb<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>IEnumerable(Of String)<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>Public Class StreamReaderEnumerable<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>IEnumerable(Of String)<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>1.GetEnumerator*> method of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interface will return a new instance of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class. The implementation of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> interface can be made <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, because you have to expose only members of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface. Replace the code that [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] generated for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> methods with the following code.\<br />     [!code[VbVbalrIteratorWalkthrough#3](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_3.vb)]|  
  
||  
|-|  
|To add the code to implement IEnumerator|  
|1.  Open the StreamReaderEnumerator.vb file.\<br />2.  On the line after <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, type the following and press ENTER.\<br />     [!code[VbVbalrIteratorWalkthrough#4](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_4.vb)]\<br />     [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] automatically populates the class with the members that are required by the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> interface.\<br />3.  The enumerator class opens the text file and performs the file I/O to read the lines from the file. Add the following code to the class to expose a public constructor that takes a file path as an input parameter and open the text file for reading.\<br />     [!code[VbVbalrIteratorWalkthrough#5](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_5.vb)]\<br />4.  The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> properties for both the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> interfaces return the current item from the text file as a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The implementation of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> property of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> interface can be made <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, because you have to expose only members of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> interface. Replace the code that [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] generated for the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> properties with the following code.\<br />     [!code[VbVbalrIteratorWalkthrough#6](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_6.vb)]\<br />5.  The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> interface navigates to the next item in the text file and updates the value that is returned by the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> property. If there are no more items to read, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>; otherwise the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. Add the following code to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method.\<br />     [!code[VbVbalrIteratorWalkthrough#7](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_7.vb)]\<br />6.  The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> interface directs the iterator to point to the start of the text file and clears the current item value. Add the following code to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method.\<br />     [!code[VbVbalrIteratorWalkthrough#8](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_8.vb)]\<br />7.  The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> interface guarantees that all unmanaged resources are released before the iterator is destroyed. The file handle that is used by the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object is an unmanaged resource and must be closed before the iterator instance is destroyed. Replace the code that [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] generated for the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> method with the following code.\<br />     [!code[VbVbalrIteratorWalkthrough#9](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_9.vb)]|  
  
## Using the Sample Iterator  
 You can use an enumerable class in your code together with control structures that require an object that implements <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, such as a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> loop or a LINQ query. The following example shows the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> in a LINQ query.  
  
 [!code[VbVbalrIteratorWalkthrough#10](../vs140/codesnippet/VisualBasic/walkthrough--implementing-ienumerable-of-t--in-visual-basic_10.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Control Flow in Visual Basic](../vs140/control-flow-in-visual-basic.md)   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)