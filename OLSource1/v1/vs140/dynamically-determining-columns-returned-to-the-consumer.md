---
title: "Dynamically Determining Columns Returned to the Consumer"
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
  - "bookmarks [C++], dynamically determining columns"
  - "dynamically determining columns [C++]"
ms.assetid: 58522b7a-894e-4b7d-a605-f80e900a7f5f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dynamically Determining Columns Returned to the Consumer
The PROVIDER_COLUMN_ENTRY macros normally handle the **IColumnsInfo::GetColumnsInfo** call. However, because a consumer might choose to use bookmarks, the provider must be able to change the columns returned depending on whether the consumer asks for a bookmark.  
  
 To handle the **IColumnsInfo::GetColumnsInfo** call, delete the PROVIDER_COLUMN_MAP, which defines a function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, from the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> user record in MyProviderRS.h and replace it with the definition for your own <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Next, implement the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function in MyProviderRS.cpp, as shown in the following code.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> checks first to see if the OLE DB property **DBPROP_BOOKMARKS** is set. To get the property, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> uses a pointer (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to the rowset object. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pointer represents the class that created the rowset, which is the class where the property map is stored. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> typecasts the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> pointer to an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pointer.  
  
 To check for the **DBPROP_BOOKMARKS** property, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interface, which you can obtain by calling <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> on the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface. As an alternative, you can use an ATL [CComQIPtr](../vs140/ccomqiptr-class.md) method instead.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example uses a static array to contain the column information. If the consumer does not want the bookmark column, one entry in the array is unused. To handle the information, you create two array macros: ADD_COLUMN_ENTRY and ADD_COLUMN_ENTRY_EX. ADD_COLUMN_ENTRY_EX takes an extra parameter, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, that is needed if you designate a bookmark column.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function, the bookmark macro is used like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can now compile and run the enhanced provider. To test the provider, modify the test consumer as described in [Implementing a Simple Consumer](../vs140/implementing-a-simple-consumer.md). Run the test consumer with the provider. Verify that the test consumer retrieves the proper strings from the provider when you click the **Run** button in the **Test Consumer** dialog box.  
  
## See Also  
 [Enhancing the Simple Read-Only Provider](../vs140/enhancing-the-simple-read-only-provider.md)