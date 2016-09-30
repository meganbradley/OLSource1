---
title: "Using the CArchive &lt;&lt; and &gt;&gt; Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CArchive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "objects [C++], loading from previously stored values"
  - "CArchive class, storing and loading objects"
  - "CArchive class, operators"
ms.assetid: 56aef326-02dc-4992-8282-f0a4b78a064e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the CArchive &lt;&lt; and &gt;&gt; Operators
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> provides <\< and >> operators for writing and reading simple data types as well as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>s to and from a file.  
  
#### To store an object in a file via an archive  
  
1.  The following example shows how to store an object in a file via an archive:  
  
     [!code[NVC_MFCSerialization#7](../vs140/codesnippet/CPP/using-the-carchive----and----operators_1.cpp)]  
  
#### To load an object from a value previously stored in a file  
  
1.  The following example shows how to load an object from a value previously stored in a file:  
  
     [!code[NVC_MFCSerialization#8](../vs140/codesnippet/CPP/using-the-carchive----and----operators_2.cpp)]  
  
 Usually, you store and load data to and from a file via an archive in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> functions of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived classes, which you must have declared with the **DECLARE_SERIALIZE** macro. A reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is passed to your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. You call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to determine whether the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function has been called to load data from the file or store data to the file.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function of a serializable <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>-derived class typically has the following form:  
  
 [!code[NVC_MFCSerialization#9](../vs140/codesnippet/CPP/using-the-carchive----and----operators_3.cpp)]  
  
 The above code template is exactly the same as the one AppWizard creates for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function of the document (a class derived from **CDocument)**. This code template helps you write code that is easier to review, because the storing code and the loading code should always be parallel, as in the following example:  
  
 [!code[NVC_MFCSerialization#10](../vs140/codesnippet/CPP/using-the-carchive----and----operators_4.cpp)]  
  
 The library defines **<\<** and **>>** operators for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as the first operand and the following data types and class types as the second operand:  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|**SIZE and CSize**|**float**|  
|**WORD**|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|**POINT** and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|**BYTE**|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|**Double**|**LONG**|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|**COleCurrency**|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>||  
  
> [!NOTE]
>  Storing and loading <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>s via an archive requires extra consideration. For more information, see [Storing and Loading CObjects via an Archive](../vs140/storing-and-loading-cobjects-via-an-archive.md).  
  
 The **CArchive <\<** and **>>** operators always return a reference to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object, which is the first operand. This enables you to chain the operators, as illustrated below:  
  
 [!code[NVC_MFCSerialization#11](../vs140/codesnippet/CPP/using-the-carchive----and----operators_5.cpp)]  
  
## See Also  
 [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md)