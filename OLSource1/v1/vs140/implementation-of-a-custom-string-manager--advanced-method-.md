---
title: "Implementation of a Custom String Manager (Advanced Method)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAtlStringMgr class, using"
ms.assetid: 64ab7da9-47c1-4c4a-9cd7-4cc37e7f3f57
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementation of a Custom String Manager (Advanced Method)
In specialized situations, you might want to implement a custom string manager that does more than just change which heap is used to allocate memory. In this situation, you must manually implement the [IAtlStringMgr](../vs140/iatlstringmgr-class.md) interface as your custom string manager.  
  
 In order to do this, it is important to first understand how [CStringT](../vs140/cstringt-class.md) uses that interface to manage its string data. Every instance of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> has a pointer to a [CStringData](../vs140/cstringdata-class.md) structure. This variable-length structure contains important information about the string (such as length), as well as the actual character data for the string. Every custom string manager is responsible for allocating and freeing these structures at the request of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure comprises four fields:  
  
-   [pStringMgr](../vs140/cstringdata--pstringmgr.md) This field points to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface used to manage this string data. When <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> needs to reallocate or free the string buffer it calls the Reallocate or Free methods of this interface, passing the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure as a parameter. When allocating a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure in your string manager, you must set this field to point to your custom string manager.  
  
-   [nDataLength](../vs140/cstringdata--ndatalength.md) This field contains the current logical length of the string stored in the buffer excluding the terminating null. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> updates this field when the length of the string changes. When allocating a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure, your string manager must set this field to zero. When reallocating a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure, your custom string manager must leave this field unchanged.  
  
-   [nAllocLength](../vs140/cstringdata--nalloclength.md) This field contains the maximum number of characters (excluding the terminating null) that can be stored in this string buffer without reallocating it. Whenever <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> needs to increase the logical length of the string, it first checks this field to make sure there is enough space in the buffer. If the check fails, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> calls into your custom string manager to reallocate the buffer. When allocating or reallocating a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure, you must set this field to at least the number of characters requested in the **nChars** parameter to [IAtlStringMgr::Allocate](../vs140/iatlstringmgr--allocate.md) or [IAtlStringMgr::Reallocate](../vs140/iatlstringmgr--reallocate.md). If there is more space in the buffer than requested, you can set this value to reflect the actual amount of space available. This allows <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to grow the string to fill the entire allocated space before it has to call back into the string manager to reallocate the buffer.  
  
-   [nRefs](../vs140/cstringdata--nrefs.md) This field contains the current reference count of the string buffer. If the value is one, then a single instance of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is using the buffer. In addition, the instance is allowed to both read and modify the contents of the buffer. If the value is greater than one, multiple instances of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can use the buffer. Because the character buffer is shared, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> instances can only read the contents of the buffer. To modify the contents, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> first makes a copy of the buffer. If the value is negative, only one instance of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is using the buffer. In this case, the buffer is considered locked. When a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> instance is using a locked buffer no other instances of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> may share the buffer. Instead, these instances create a copy of the buffer before manipulating the contents. In addition, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> instance using the locked buffer does not attempt to share the buffer of any other <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> instance assigned to it. In this case, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> instance copies the other string into the locked buffer.  
  
     When allocating a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure, you must set this field to reflect the type of sharing that is allowed for the buffer. For most implementations, set this value to one. This allows the usual copy-on-write sharing behavior. However, if your string manager does not support sharing the string buffer, set this field to a locked state. This forces <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to only use this buffer for the instance of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> that allocated it.  
  
## See Also  
 [Memory Management with CStringT](../vs140/memory-management-with-cstringt.md)