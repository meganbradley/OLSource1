---
title: "Storing and Loading CObjects via an Archive"
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
  - "CObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObjects, loading through archives"
  - "CArchive class, storing and loading objects"
  - "Serialize method, vs. CArchive operators"
  - "CObject class, CArchive objects"
  - "CObjects"
ms.assetid: a829b6dd-bc31-47e0-8108-fbb946722db9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storing and Loading CObjects via an Archive
Storing and loading <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>s via an archive requires extra consideration. In certain cases, you should call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function of the object, where the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is a parameter of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> call, as opposed to using the **<\<** or **>>** operator of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The important fact to keep in mind is that the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **>>** operator constructs the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in memory based on <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> information previously written to the file by the storing archive.  
  
 Therefore, whether you use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **<\<** and **>>** operators, versus calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, depends on whether you *need* the loading archive to dynamically reconstruct the object based on previously stored <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> information. Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function in the following cases:  
  
-   When deserializing the object, you know the exact class of the object beforehand.  
  
-   When deserializing the object, you already have memory allocated for it.  
  
> [!CAUTION]
>  If you load the object using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function, you must also store the object using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function. Don't store using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> **<<** operator and then load using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function, or store using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function and then load using **CArchive >>** operator.  
  
 The following example illustrates the cases:  
  
 [!code[NVC_MFCSerialization#36](../vs140/codesnippet/CPP/storing-and-loading-cobjects-via-an-archive_1.h)]  
  
 [!code[NVC_MFCSerialization#37](../vs140/codesnippet/CPP/storing-and-loading-cobjects-via-an-archive_2.cpp)]  
  
 In summary, if your serializable class defines an embedded **CObjec**t as a member, you should *not* use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **<\<** and **>>** operators for that object, but should call the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function instead. Also, if your serializable class defines a pointer to a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (or an object derived from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) as a member, but constructs this other object in its own constructor, you should also call <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## See Also  
 [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md)