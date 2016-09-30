---
title: "Target Build Order"
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
  - "msbuild, build order"
ms.assetid: f4a26339-9f9a-497a-9aa6-0797183d450d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Target Build Order
Targets must be ordered if the input to one target depends on the output of another target. You can use these attributes to specify the order in which targets are run:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute specifies the targets that will run first, even if targets are specified on the command line or in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. This <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> atttribute specifies which targets are run if a target is not specified explicitly on the command line.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute specifies targets that must run before this target can run.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. These <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attributes specify that this target should run before or after the specified targets (MSBuild 4.0).  
  
 A target is never run twice during a build, even if a subsequent target in the build depends on it. Once a target has been run, its contribution to the build is complete.  
  
 Targets may have a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute. If the specified condition evaluates to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the target isn't executed and has no effect on the build. For more information about conditions, see [MSBuild Conditions](../vs140/msbuild-conditions.md).  
  
## Initial Targets  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute of the [Project](../vs140/project-element--msbuild-.md) element specifies targets that will run first, even if targets are specified on the command line or in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute. Initial targets are typically used for error checking.  
  
 The value of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute can be a semicolon-delimited, ordered list of targets. The following example specifies that the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> target runs, and then the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> target runs.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Imported projects may have their own <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attributes. All initial targets are aggregated together and run in order.  
  
 For more information, see [How to: Specify Which Target to Build First](../vs140/how-to--specify-which-target-to-build-first.md).  
  
## Default Targets  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute of the [Project](../vs140/project-element--msbuild-.md) element specifies which target or targets are built if a target isn't specified explicitly in a command line.  
  
 The value of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute can be a semicolon-delimited, ordered list of default targets. The following example specifies that the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> target runs, and then the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> target runs.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can override the default targets by using the **/target** switch on the command line. The following example specifies that the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> target runs, and then the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> target runs. When you specify targets in this way, any default targets are ignored.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 If both initial targets and default targets are specified, and if no command-line targets are specified, MSBuild runs the initial targets first, and then runs the default targets.  
  
 Imported projects may have their own <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attributes. The first <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> attribute encountered determines which default targets will run.  
  
 For more information, see [How to: Specify Which Target to Build First](../vs140/how-to--specify-which-target-to-build-first.md).  
  
## First Target  
 If there are no initial targets, default targets, or command-line targets, then MSBuild runs the first target it encounters in the project file or any imported project files.  
  
## Target Dependencies  
 Targets can describe dependency relationships with each other. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> attribute indicates that a target depends on other targets. For example,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 tells MSBuild that the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> target depends on the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> target and the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> target. MSBuild runs the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> target, and then runs the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> target before it runs the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> target.  
  
## BeforeTargets and After Targets  
 In MSBuild 4.0, you can specify target order by using the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> attributes.  
  
 Consider the following script.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To create an intermediate target <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> that runs after the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> target, but before the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> target, add the following target anywhere in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Determining the Target Build Order  
 MSBuild determines the target build order as follows:  
  
1.  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> targets are run.  
  
2.  Targets specified on the command line by the **/target** switch are run. If you specify no targets on the command line, then the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> targets are run. If neither is present, then the first target encountered is run.  
  
3.  The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> attribute of the target is evaluated. If the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attribute is present and evaluates to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, the target isn't executed and has no further effect on the build.  
  
4.  Before a target is executed, its <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> targets are run.  
  
5.  Before a target is executed, any target that lists it in a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> attribute is run.  
  
6.  Before a target is executed, its <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> attribute and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute are compared. If MSBuild determines that any output files are out of date with respect to the corresponding input file or files, then MSBuild executes the target. Otherwise, MSBuild skips the target.  
  
7.  After a target is executed or skipped, any target that lists it in an <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> attribute is run.  
  
## See Also  
 [Targets](../vs140/msbuild-targets.md)