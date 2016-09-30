---
title: "Modifying the Inheritance of RMyProviderRowset"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RMyProviderRowset"
  - "inheritance [C++]"
ms.assetid: 33089c90-98a4-43e7-8e67-d4bb137e267e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Modifying the Inheritance of RMyProviderRowset
To add the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface to the simple read-only provider example, modify the inheritance of **RMyProviderRowset**. Initially, **RMyProviderRowset** inherits from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You need to modify it to inherit from **CRowsetBaseImpl**.  
  
 To do this, create a new class, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, in MyProviderRS.h:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Now, edit the COM interface map in MyProviderRS.h to be as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This creates a COM interface map that tells <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to call **QueryInterface** for both the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interfaces. To get all of the implementation for the other rowset classes, the map links the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class back to the **CRowsetBaseImpl** class defined by the OLE DB Templates; the map uses the COM_INTERFACE_ENTRY_CHAIN macro, which tells OLE DB templates to scan the COM map in **CRowsetBaseImpl** in response to a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> call.  
  
 Finally, link <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> by modifying <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to inherit from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can now use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interface while taking advantage of the rest of the implementation for the rowset class.  
  
 When this is done, you can [dynamically determine columns returned to the consumer](../vs140/dynamically-determining-columns-returned-to-the-consumer.md).  
  
## See Also  
 [Enhancing the Simple Read-Only Provider](../vs140/enhancing-the-simple-read-only-provider.md)