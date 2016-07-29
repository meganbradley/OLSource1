---
title: "Creating Session-Scoped Named Sets (MDX)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b751e1e4-6d4c-4d36-a28d-ffdaaee0f1c7
caps.latest.revision: 30
manager: mblythe
---
# Creating Session-Scoped Named Sets (MDX)
To create a named set that is available throughout a Multidimensional Expressions (MDX) session, you use the [CREATE SET](assetId:///eff51eeb-5e7e-4706-b861-c57b6f3f89f0) statement. A named set that is created by using the CREATE SET statement will not be removed until after the MDX session closes.  
  
 As discussed in this topic, the syntax of the WITH keyword is straightforward and easy to use.  
  
> [!NOTE]  
>  For more information about named sets, see [Building Named Sets in MDX (MDX)](../../Topics/TopicNameNotContainA/Building-Named-Sets-in-MDX--MDX-.md).  
  
## CREATE SET Syntax  
 Use the following syntax for the CREATE SET statement:  
  
```  
CREATE SESSION SET [CURRENTCUBE. | <cube name>.]<Set Identifier> AS <Set Expression>  
```  
  
 In the CREATE SET syntax, the `cube name` parameter contains the name of the cube that contains the members for the named set. If the `cube name` parameter is not specified, the current cube will be used as the cube that contains the member for the named set. Also, the `Set_Identifier` parameter contains the alias for the named set, and the `Set_Expression` parameter contains the set expression to which the named set alias will refer.  
  
## CREATE SET Example  
 The following example uses the CREATE SET statement to create the `SetCities_2_3` named set based on the Store cube. The members of the `SetCities_2_3` named set are the stores within City 2 and City 3.  
  
```  
create Session set [Store].[SetCities_2_3] as  
{[Data Stores].[ByLocation].[State].&[CA].&[City 02],  
[Data Stores].[ByLocation].[State].&[NH].&[City 03]}  
```  
  
 By using the CREATE SET statement to define the `SetCities_2_3` named set, this named set remains available for the length of the current MDX session. The following example is a valid query that would return City 2 and City 3 members, and that could be run anytime after you create the `SetCities_2_3` named set and before the session closes.  
  
```  
select SetCities_2_3 on 0 from [Store]  
```  
  
## See Also  
 [Creating Query-Scoped Named Sets (MDX)](../../Topics/TopicNameNotContainA/Creating-Query-Scoped-Named-Sets--MDX-.md)