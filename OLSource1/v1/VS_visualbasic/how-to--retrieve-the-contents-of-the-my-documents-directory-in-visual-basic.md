---
title: "How to: Retrieve the Contents of the My Documents Directory in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 13
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Retrieve the Contents of the My Documents Directory in Visual Basic
The \<xref:Microsoft.VisualBasic.FileIO.SpecialDirectories> object can be used to read from many of the **All Users** directories, such as **My Documents** or **Desktop**.  
  
### To read from the My Documents folder  
  
-   Use the `ReadAllText` method to read the text from each file in a specific directory. The following code specifies a directory and file and then uses `ReadAllText` to read them into the string named `patients`.  
  
     [!code[VbVbcnMyFileSystem#15](../VS_visualbasic/codesnippet/VisualBasic/how-to--retrieve-the-contents-of-the-my-documents-directory-in-visual-basic_1.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.SpecialDirectories>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.ReadAllText*>