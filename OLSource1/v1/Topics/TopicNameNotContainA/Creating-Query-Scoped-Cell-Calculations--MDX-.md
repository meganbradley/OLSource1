---
title: Creating Query-Scoped Cell Calculations (MDX)
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
ms.assetid: 45987daa-4400-41e9-add7-2428fd75709b
manager: mblythe
---
# Creating Query-Scoped Cell Calculations (MDX)
You use the **WITH** keyword in Multidimensional Expressions (MDX) to describe calculated cells within the context of a query. The **WITH** keyword has the following syntax:  
  
```  
WITH CELL CALCULATION Cube_Name.CellCalc_Identifier  String_Expression  
```  
  
 The `CellCalc_Identifier` value is the name of the calculated cells. The `String_Expression` value contains a list of orthogonal, single-dimensional MDX set expressions. Each of these set expressions must resolve to one of the categories listed in the following table.  
  
|Category|Description|  
|--------------|-----------------|  
|Empty set|An MDX set expression that resolves into an empty set. In this case, the scope of the calculated cell is the whole cube.|  
|Single member set|An MDX set expression that resolves into a single member.|  
|Set of level members|An MDX set expression that resolves into the members of a single level. An example of such a set expression is the *Level_Expression*.**Members** MDX function. To include calculated members, use the *Level_Expression*.**AllMembers** MDX function. For more information, see [CREATE CELL CALCULATION Statement (MDX)](assetId:///202e81d4-d2ee-4ec1-a019-4835eb19f446).|  
|Set of descendants|An MDX set expression that resolves into the descendants of a specified member. An example of such a set expression is the **Descendants**(*Member_Expression*, *Level_Expresion*, *Desc_Flag*) MDX function. For more information, see [Descendants (MDX)](assetId:///d103b0f5-e794-4828-aa57-43f6918a0749).|  
  
 If the `String_Expression` argument does not describe a dimension, MDX assumes that all members are included for the purposes of constructing the calculation subcube. Therefore, if the `String_Expression` argument is NULL, the calculated cells definition applies to the whole cube.  
  
 The `MDX_Expression` argument contains an MDX expression that evaluates to a cell value for all the cells defined in the `String_Expression` argument.  
  
## Additional Considerations  
 MDX processes the calculation condition, specified by the **CONDITION** property, only once. This single processing provides increased performance for the evaluation of multiple calculated cells definitions, especially with overlapping calculated cells across cube passes.  
  
 When this single processing occurs depends on the creation scope of the calculated cells definition:  
  
-   If created at global scope, as part of a cube, MDX process the calculation condition when the cube is processed. If cells are modified in the cube in any way, and the cells are included in the calculation subcube of a calculated cells definition, the calculation condition may not be accurate until the cube is reprocessed. Cell modification can occur from writebacks, for example. The calculation condition is reprocessed when the cube is reprocessed.  
  
-   If created at session scope, MDX process the calculation condition when the statement is issued during the session. As with calculated cells definitions created globally, if the cells are modified, the calculation condition may not be accurate for the calculated cells definition.  
  
-   If created at query scope, MDX processes the calculation condition when the query runs. The cell modification issue applies here, also, although data latency issues are minimal because of the low processing time of MDX query execution.  
  
 On the other hand, MDX processes the calculation formula whenever an MDX query is issued against the cube involving cells included in the calculated cells definition. This processing occurs regardless of the creation scope.  
  
## See Also  
 [CREATE CELL CALCULATION Statement (MDX)](assetId:///01ced1b3-ada1-4b55-b350-e4255c3cc679)