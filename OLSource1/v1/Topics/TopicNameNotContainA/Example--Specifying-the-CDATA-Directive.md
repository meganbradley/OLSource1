---
title: Example: Specifying the CDATA Directive
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-xml
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 949071e6-787f-480d-bb86-3ac16a027af1
---
# Example: Specifying the CDATA Directive
  If the directive is set to **CDATA**, the contained data is not entity encoded, but is put in the CDATA section. The **CDATA** attributes must be nameless.  
  
 The following query wraps the product model summary description in a CDATA section.  
  
```  
USE AdventureWorks2012;  
GO  
SELECT  1 as Tag,  
        0 as Parent,  
        ProductModelID  as [ProductModel!1!ProdModelID],  
        Name            as [ProductModel!1!Name],  
        '<Summary>This is summary description</Summary>'     
            as [ProductModel!1!!CDATA] -- no attribute name so ELEMENT assumed  
FROM    Production.ProductModel  
WHERE   ProductModelID=19  
FOR XML EXPLICIT  
```  
  
 This is the result:  
  
```  
<ProductModel ProdModelID="19" Name="Mountain-100">  
   <![CDATA[<Summary>This is summary description</Summary>]]>  
</ProductModel>  
```  
  
## See Also  
 [Use EXPLICIT Mode with FOR XML](../../Topics\TopicNameNotContainA/Use-EXPLICIT-Mode-with-FOR-XML.md)  
  
  