---
title: "Using Multiple Result Sets from One Stored Procedure"
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
  - "stored procedures, returning result sets"
  - "multiple result sets"
ms.assetid: c450c12c-a76c-4ae4-9675-071a41eeac05
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Multiple Result Sets from One Stored Procedure
Most stored procedures return multiple result sets. Such a stored procedure usually includes one or more select statements. The consumer needs to consider this to handle all the result sets.  
  
### To handle multiple result sets  
  
1.  Create a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> as a template argument and with the accessor of your choice. Usually, this is a dynamic or manual accessor. If you use another type of accessor, you might not be able to determine the output columns for each rowset.  
  
2.  Execute the stored procedure as usual and bind the columns (see [How Do I Fetch Data?](../vs140/fetching-data.md)).  
  
3.  Use the data.  
  
4.  Call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class. If another result rowset is available, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns S_OK and you should rebind your columns if you are using a manual accessor. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns an error, there are no further result sets available.  
  
## See Also  
 [Using Stored Procedures](../vs140/using-stored-procedures.md)