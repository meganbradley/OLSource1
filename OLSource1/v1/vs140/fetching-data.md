---
title: "Fetching Data"
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
  - "data [C++], fetching"
  - "rowsets [C++], fetching"
  - "fetching"
  - "OLE DB consumer templates [C++], fetching data"
ms.assetid: b07f747f-9855-4f27-a03d-b1d5b10fa284
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fetching Data
After you open the data source, session, and rowset objects, you can fetch data. Depending on the type of accessor you are using, you might need to bind columns.  
  
### To fetch data  
  
1.  Open the rowset using the appropriate **Open** command.  
  
2.  If you are using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, bind the output columns if you have not already done so. To bind the columns, call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and then create an accessor with the bindings, as shown in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Write a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> loop to retrieve the data. In the loop, call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to advance the cursor and test the return value against S_OK, as shown in the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Within the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loop, you can fetch the data according to your accessor type.  
  
    -   If you use the [CAccessor](../vs140/caccessor-class.md) class, you should have a user record that contains data members. You can access your data using those data members, as shown in the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
    -   If you use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class, you can fetch data by using the accessing functions <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, as shown in the following example. If you want to determine the type of data you are using, use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    -   If you use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, you must specify your own data members, bind them yourself, and access them directly, as shown in the following example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Working with OLE DB Consumer Templates](../vs140/working-with-ole-db-consumer-templates.md)