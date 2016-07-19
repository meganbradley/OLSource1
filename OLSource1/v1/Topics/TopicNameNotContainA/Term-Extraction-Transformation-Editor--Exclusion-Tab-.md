---
title: Term Extraction Transformation Editor (Exclusion Tab)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 90110d95-fd97-4542-9cda-832c86606130
manager: jhubbard
---
# Term Extraction Transformation Editor (Exclusion Tab)
Use the **Exclusion** tab of the **Term Extraction Transformation Editor** dialog box to set up a connection to an exclusion table and specify the columns that contain exclusion terms.  
  
 To learn more about the Term Extraction transformation, see [Term Extraction Transformation](../../Topics/TopicNameNotContainA/Term-Extraction-Transformation.md).  
  
## Options  
 **Use exclusion terms**  
 Indicate whether to exclude specific terms during term extraction by specifying a column that contains exclusion terms. You must specify the following source properties if you choose to exclude terms.  
  
 **OLE DB connection manager**  
 Select an existing OLE DB connection manager, or create a new connection by clicking **New**.  
  
 **New**  
 Create a new connection to a database by using the **Configure OLE DB Connection Manager** dialog box.  
  
 **Table or view**  
 Select the table or view that contains the exclusion terms.  
  
 **Column**  
 Select the column in the table or view that contains the exclusion terms.  
  
 **Configure Error Output**  
 Use the [Configure Error Output](../../Topics/TopicNameNotContainA/Configure-Error-Output.md) dialog box to specify error handling for rows that cause errors.  
  
## See Also  
 [Integration Services Error and Message Reference](../../Topics/TopicNameNotContainA/Integration-Services-Error-and-Message-Reference.md)   
 [Term Extraction Transformation Editor (Term Extraction Tab)](../../Topics/TopicNameNotContainA/Term-Extraction-Transformation-Editor--Term-Extraction-Tab-.md)   
 [Term Extraction Transformation Editor (Advanced Tab)](../../Topics/TopicNameNotContainA/Term-Extraction-Transformation-Editor--Advanced-Tab-.md)   
 [Term Lookup Transformation](../../Topics/TopicNameNotContainA/Term-Lookup-Transformation.md)