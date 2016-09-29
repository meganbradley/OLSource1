---
title: "ItemGroup Element (MSBuild)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#ItemGroup"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ItemGroup element [MSBuild]"
  - "<ItemGroup> element [MSBuild]"
ms.assetid: aac894e3-a9f1-4bbc-a796-6ef07001f35b
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ItemGroup Element (MSBuild)
Contains a set of user-defined [Item](../VS_csharp/item-element--msbuild-.md) elements. Every item used in a [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] project must be specified as a child of an `ItemGroup` element.  
  
 <Project\>  
 <ItemGroup\>  
  
## Syntax  
  
```  
<ItemGroup Condition="'String A' == 'String B'">  
    <Item1>... </Item1>  
    <Item2>... </Item2>  
</ItemGroup>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute. Condition to be evaluated. For more information, see [MSBuild Conditions](../VS_csharp/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Item](../VS_csharp/item-element--msbuild-.md)|Defines the inputs for the build process. There may be zero or more `Item` elements in an `ItemGroup`.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../VS_csharp/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] project file.|  
|[Target](../VS_csharp/target-element--msbuild-.md)|Starting with .NET Framework 3.5, the `ItemGroup` element can appear inside a `Target` element. For more information, see [MSBuild Targets](../VS_csharp/msbuild-targets.md).|  
  
## Remarks  
  
## Example  
 The following code example shows the user-defined item collections `Res` and `CodeFiles` declared inside of an `ItemGroup` element. Each of the items in the `Res` item collection contains a user-defined child [ItemMetadata](../VS_csharp/itemmetadata-element--msbuild-.md) element.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ItemGroup>  
        <Res Include = "Strings.fr.resources" >  
            <Culture>fr</Culture>  
        </Res>  
        <Res Include = "Dialogs.fr.resources" >  
            <Culture>fr</Culture>  
        </Res>  
  
        <CodeFiles Include="**\*.cs" Exclude="**\generated\*.cs" />  
        <CodeFiles Include="..\..\Resources\Constants.cs" />  
    </ItemGroup>  
...  
</Project>  
```  
  
## See Also  
 [MSBuild File Format](../VS_csharp/msbuild-project-file-schema-reference.md)   
 [MSBuild Items](../VS_csharp/msbuild-items.md)   
 [Common MSBuild Project Items](../VS_csharp/common-msbuild-project-items.md)