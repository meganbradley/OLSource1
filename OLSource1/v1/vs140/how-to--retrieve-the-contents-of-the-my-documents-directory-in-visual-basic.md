---
title: "How to: Retrieve the Contents of the My Documents Directory in Visual Basic"
ms.custom: na
ms.date: "09/21/2016"
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
  - "My Documents directory"
ms.assetid: 26560d01-7dda-4457-8e95-21db23d71aea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Retrieve the Contents of the My Documents Directory in Visual Basic
The \<xref:Microsoft.VisualBasic.FileIO.SpecialDirectories*> object can be used to read from many of the **All Users** directories, such as **My Documents** or **Desktop**.  
  
### To read from the My Documents folder  
  
-   Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method to read the text from each file in a specific directory. The following code specifies a directory and file and then uses <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to read them into the string named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
     [!code[VbVbcnMyFileSystem#15](../vs140/codesnippet/VisualBasic/how-to--retrieve-the-contents-of-the-my-documents-directory-in-visual-basic_1.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.SpecialDirectories*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.ReadAllText*>