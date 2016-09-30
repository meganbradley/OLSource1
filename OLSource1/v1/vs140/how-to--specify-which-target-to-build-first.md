---
title: "How to: Specify Which Target to Build First"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "DefaultTargets attribute [MSBuild]"
  - "MSBuild, specifying the defalut target"
  - "MSBuild, DefaultTargets attribute"
ms.assetid: a580ba5b-2919-42d2-ae38-1af991e0205a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify Which Target to Build First
A project file can contain one or more <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> elements that define how the project is built. The [!INCLUDE[vstecmsbuildengine](../vs140/includes/vstecmsbuildengine_md.md)] ([!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]) engine builds the first project it finds, and any dependencies, unless the project file contains a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attribute, an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute, or a target is specified at the command line using the **/target** switch.  
  
## Using the InitialTargets Attribute  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element specifies a target that will run first, even if targets are specified on the command line or in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute.  
  
#### To specify one initial target  
  
-   Specify the default target in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element. For example:  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 You can specify more than one initial target in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute by listing the targets in order, and using a semicolon to separate each target. The targets in the list will be run sequentially.  
  
#### To specify more than one initial target  
  
-   List the initial targets, separated by semicolons, in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element. For example, to run the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> target and then the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> target, type:  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Using the DefaultTargets Attribute  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element specifies which target or targets are built if a target is not specified explicitly on the command line. If targets are specified in both the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attributes and no target is specified on the command line, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] runs the targets specified in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute followed by the targets specified in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute.  
  
#### To specify one default target  
  
-   Specify the default target in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element. For example:  
  
     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 You can specify more than one default target in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute by listing the targets in order, and using a semicolon to separate each target. The targets in the list will be run sequentially.  
  
#### To specify more than one default target  
  
-   List the default targets, separated by semicolons, in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> element. For example, to run the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> target and then the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> target, type:  
  
     <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
## Using the /target Switch  
 If a default target is not defined in the project file, or if you do not want to use that default target, you can use the command line switch **/target** to specify a different target. The target or targets specified with the **/target** switch are run instead of the targets specified by the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attribute. Targets specified in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> attribute always run first.  
  
#### To use a target other than the default target first  
  
-   Specify the target as the first target using the **/target** command line switch. For example:  
  
     <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
#### To use several targets other than the default targets first  
  
-   List the targets, separated by semicolons or commas, using the **/target** command line switch. For example:  
  
     <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
## See Also  
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Targets](../vs140/msbuild-targets.md)   
 [How To: Clean a Build](../vs140/how-to--clean-a-build.md)