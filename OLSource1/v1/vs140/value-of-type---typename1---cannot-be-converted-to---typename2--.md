---
title: "Value of type &#39;&lt;typename1&gt;&#39; cannot be converted to &#39;&lt;typename2&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30955"
  - "bc30955"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30955"
ms.assetid: 966b61eb-441e-48b0-bedf-ca95384ecb8b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value of type &#39;&lt;typename1&gt;&#39; cannot be converted to &#39;&lt;typename2&gt;&#39;
Value of type '\<typename1>' cannot be converted to '\<typename2>'. Type mismatch could be due to the mixing of a file reference with a project reference to assembly '\<assemblyname>'. Try replacing the file reference to '\<filepath>' in project '\<projectname1>' with a project reference to '\<projectname2>'.  
  
 In a situation where a project makes both a project reference and a file reference, the compiler cannot guarantee that one type can be converted to another.  
  
 The following pseudo-code illustrates a situation that can generate this error.  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 Project <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> makes an indirect project reference through project <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to project <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and also a direct file reference to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The declaration of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> uses the file reference to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, while the call to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> uses the project reference to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The problem in this situation is that the file reference specifies a file path and name for the output file of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (typically p3.dll), while the project references identify the source project (<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) by project name. Because of this, the compiler cannot guarantee that the type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> comes from the same source code through the two different references.  
  
 This situation typically occurs when project references and file references are mixed. In the preceding illustration, the problem would not occur if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> made a direct project reference to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> instead of a file reference.  
  
 **Error ID:** BC30955  
  
### To correct this error  
  
-   Change the file reference to a project reference.  
  
## See Also  
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Managing Project References](../vs140/managing-references-in-a-project.md)   
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)