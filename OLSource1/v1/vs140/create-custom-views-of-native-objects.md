---
title: "Create custom views of native objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "natvis"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 2d9a177a-e14b-404f-a6af-49498eff0bd7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Create custom views of native objects
The Visual Studio Natvis framework lets you customize the way Visual Studio displays native types in debugger variable windows (for example, the **Watch**, **Locals**, and **Data Tips** windows.  
  
 Natvis supersedes the **autoexp.dat** file that was used in earlier versions of Visual Studio and offers XML syntax, better diagnostics, versioning, and multiple file support.  
  
> [!NOTE]
>  You cannot use the Natvis framework for visualizations when:  
>   
>  -   You are debugging a C++ Windows desktop project with debugger type set to **mixed**.  
> -   You are doing mixed mode debugging in a Windows desktop application in managed compatibility mode (**Tools / Options / Debugging / General / Use Managed Compatibility Mode**).  
> -   You are debugging in a Windows desktop application in native compatibility mode (**Tools / Options / Debugging / General / Use Native Compatibility Mode**).  
  
##  \<a name="BKMK_Why_create_visualizations_">\</a> Why create Natvis visualizations?  
 You can use the Natvis framework to create visualization rules for the types you create so developers can see them easily during debugging.  
  
 For example, the image below shows a variable of type [Windows::UI::Xaml::Controls::TextBox](http://go.microsoft.com/fwlink/?LinkId=258422) that is displayed in the debugger without any custom visualizations applied.  
  
 ![TextBox default visualization](../vs140/media/dbg_natvis_textbox_default.png "DBG_NATVIS_TextBox_Default")  
  
 The highlighted row shows the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> property of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class. The complex class hierarchy makes it difficult to find this value; moreover, the debugger doesn’t know how to interpret the custom string type used by the object, so you cannot see the string held inside the textbox.  
  
 The same <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> looks much simpler n the variable window when custom visualization rules are applied. The important members of the class can be viewed together, and the debugger shows the underlying string value of the custom string type.  
  
 ![TextBox data using visualizer](../vs140/media/dbg_natvis_textbox_visualizer.png "DBG_NATVIS_TextBox_Visualizer")  
  
##  \<a name="BKMK_Using_Natvis_files">\</a> Using Natvis files  
 .natvis files are XML files with a .natvis extension. The schema is defined in **%VSINSTALLDIR%\Xml\Schemas\natvis.xsd**.  
  
 The basic structure of a .natvis file is one or more <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> elements, where each <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> element represents a visualization entry for a type whose fully qualified name is specified in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Visual Studio provides some .natvis files in **%VSINSTALLDIR%\Common7\Packages\Debugger\Visualizers** folder. These files contain visualization rules for many common types and can serve as examples when you are writing visualizations for new types.  
  
## Adding .natvis files to your projects  
 You can add .natvis files to any C++ project.  
  
 To add a new .natvis file, with an open C++ project, select the project node in the **Solution Explorer**, and click **Add / New item / Visual C++ / Utility / Debugger visualization file (.natvis)**. The debugger will load Natvis files from C++ projects automatically. By default, Natvis files in your project are also inserted into the .pdb file built by the project. This means that if you debug the binary built by this project, the debugger loads the Natvis file from the .pdb even if you do not have the project open. If you do not want the .natvis file to be included in the .pdb, right-click the .natvis file in the **Solution Explorer**, and in the **Configuration Properties** window set **Excluded from Build** to **Yes**.  
  
 It is recommended that you edit Natvis files using Visual Studio Any changes you make while debugging take effect automatically when you save the file. You also get an improved editing experience from IntelliSense.  
  
 Natvis files that are loaded from a .pdb apply only to types in the module to which the pdb refers. For example, if Module1.pdb defines an entry for a type named <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, this entry only applied to the **Test** class in Module1.dll. If another module also defines a class named **Test**, Module1.pdb’s natvis entry does not apply to it.  
  
##  \<a name="BKMK_natvis_location">\</a> Deploying .natvis files  
 If your .natvis file applies only to the types you are creating in a Visual Studio project, you don’t have to do anything; the .natvis is included in the .pdb. You can, however, add .natvis files to your user directory or to a system directory if you want them to apply to multiple projects.  
  
 The order in which .natvis files are evaluated is as follows:  
  
1.  .natvis files embedded in a .pdb you are debugging (unless a file of the same name exists in a loaded project)  
  
2.  .natvis files that are part of a loaded C++ projects or a top-level solution item. This includes all loaded C++ projects, including class libraries, but it does not include projects of other languages (e.g. you can’t load a .natvis file from a C# project). For executable projects, you should use the solution items to host any .natvis files that are not already present in a .pdb, since there is no C++ project available.  
  
3.  The user-specific natvis directory (**%USERPROFILE%\My Documents\Visual Studio 2015\Visualizers**  
  
4.  The system-wide Natvis directory (**%VSINSTALLDIR%\Common7\Packages\Debugger\Visualizers**). This is where .natvis files that are installed with Visual Studio are copied. You can add other files to this directory as well if you have administrator permissions.  
  
## Modifying .natvis files while debugging  
 You can modify a .natvis file in the IDE while debugging the project in which it is included. Open the file in the IDE (using the same instance of Visual Studio that you are debugging with), modify it, and save it. As soon as the file is saved, the **Watch** and **Locals** windows should be updated to reflect the change. If you modify the .natvis file outside the IDE, the changes do not take effect automatically. To update the windows, you can evaluate the **.natvisreload** command in the **Watch** window. This causes the changes to take effect without restarting the debug session.  
  
 You can also add or delete .natvis files to a solution you are debugging, and Visual Studio will add or remove the relevant visualizations.  
  
 You cannot modify a .natvis file while you are debugging if it is embedded in a .pdb.  
  
 Use the **.natvisreload** command when you are upgrading the natvis file to a newer version (for example, if it’s checked into source control and you want to pick up recent changes that somebody else made to the file). It is recommended that you edit natvis files using the Visual Studio xml editor.  
  
##  \<a name="BKMK_Expressions_and_formatting">\</a> Expressions and formatting  
 Natvis visualizations use C++ expressions to specify the data items to display. In addition to the enhancements and limitations of C++ expressions in the debugger that are described in [Expressions in Native C++](../vs140/context-operator--c---.md), you should be aware of the following differences:  
  
-   Natvis expressions are evaluated in the context of the object being visualized, not the current stack frame. For example, if you use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in a Natvis expression, this refers to the field named <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> in the object being visualized, not to a local variable named <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> in the currently-executing function. You cannot access local variables in Natvis expressions, although you can access global variables.  
  
-   Natvis expressions do not allow function evaluation or side effects. This means that function calls and assignment operators are ignored. Because [debugger intrinsic functions](../vs140/expressions-in-the-debugger.md#BKMK_Using_debugger_intrinisic_functions_to_maintain_state) are side-effect free, they may be freely called from any Natvis expression, even though other function calls are disallowed.  
  
 To control how an expression is displayed in a variable window, you can use any of the format specifiers that are described in the [Visual Studio format specifiers](../vs140/format-specifiers-in-c--.md#BKMK_Visual_Studio_2012_format_specifiers) section of the [Format Specifiers in C++](../vs140/format-specifiers-in-c--.md) topic. Note that format specifiers are ignored when the virtualization entry is used internally by Natvis, such as the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> expression in in a [ArrayItems expansion](../vs140/create-custom-views-of-native-objects.md#BKMK_ArrayItems_expansion).  
  
## Natvis views  
 Natvis views allow you to see any type in more than one way. For example, you can define a view named **simple** that gives you a simplified view of a type. For example, here is the visualization of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> elements are used in the default view and the simple view, while the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> items are excluded from the simple view. You can use the **,view** format specifier to specify an alternate view. In the **Watch** window, you specify the simple view as **vec,view(simple)**:  
  
 ![Watch window with simple view](../vs140/media/watch-simpleview.png "Watch-SimpleView")  
  
##  \<a name="BKMK_Diagnosing_Natvis_errors">\</a> Diagnosing Natvis errors  
 You can use Natvis diagnostics to troubleshoot syntax and parse errors. When the debugger encounters errors in a visualization entry, it ignores the errors and either displays the type in its raw form or picks another suitable visualization. To understand why a certain visualization entry is ignored and to see what the underlying errors are, you can turn on Natvis diagnostics **Tools / Options / Debugging / Output Window / Natvis diagnostic messages (C++ only)** option. The errors are displayed in the **Output** window.  
  
##  \<a name="BKMK_Syntax_reference">\</a> Natvis syntax reference  
  
###  \<a name="BKMK_AutoVisualizer">\</a> AutoVisualizer element  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  element is the root node of the .natvis file and contains the namespace <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Type">\</a> Type element  
 A basic Type looks like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 It specifies:  
  
1.  What type this visualization should be used for (the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> attribute).  
  
2.  What the value of an object of that type should look like (the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> element).  
  
3.  What the members of the type should look like when the user expands it in a variable window (the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> node).  
  
 **Templated classes** The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> element accepts an asterisk <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> as a wildcard character that can be used for templated class names:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In this example, the same visualization will be used whether the object is a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. If there is a specific visualization entry for a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> then it takes precedence over the generic one.  
  
 Note that template parameters can be referenced in the visualization entry by using macros $T1, $T2, and so forth. To find examples of these macros, see the .natvis files shipped with Visual Studio.  
  
####  \<a name="BKMK_Visualizer_type_matching">\</a> Visualizer type matching  
 If a visualization entry fails to validate, then the next available visualization is used.  
  
#### Inheritable attribute  
 You can specify whether a visualization applies only to a base type or to a base type and all derived types with the optional <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> attribute. In the following, the visualization applies only to the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> type:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The default value of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
#### Priority attribute  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> attribute specifies the order in which alternate definitions are used if a definition fails to parse. The possible values of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are: <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, and the default value is <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 The priority attribute should only be used to distinguish between priorities within the same .natvis file, not between different files.  
  
 In the following example, we will first parse the entry that matches the 2015 STL, and if that fails to parse, we will use the alternate entry for the 2013 version of the STL:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
####  \<a name="BKMK_Versioning">\</a> Version element  
 Use the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> element to scope visualizations to specific modules and their versions so that name collisions can be minimized and different visualizations can be used for different versions of the types. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In this example, the visualization is applicable only for the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> type found in the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> from version 1.0 to 1.5. Note that adding version elements scopes the visualization entry to a particular module and version and reduces inadvertent mismatches, but if a type is defined in a common header file that is used by different modules, the versioned visualization is not applied when the type is not in the specified module.  
  
#### Optional attribute  
 The <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> attribute can appear on any node. If any sub-expression inside an optional node fails to parse, that node is ignored, but the rest of the Type element is still valid. In the following type, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is non-optional, but <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is optional.  This means that if <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> contains a field named _<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, you will still both <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> node and the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> node, but if the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is missing, you will see only the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> node.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
###  \<a name="BKMK_Condition_attribute">\</a> Condition attribute  
 The optional <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> attribute is available for many visualization elements and specifies when a visualization rule should be used. If the expression inside the condition attribute resolves to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, then the visualization rule specified by the element is not applied. If it evaluates to true, or if there is no <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> attribute, then the visualization rule is applied to the type. You can use this attribute for <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> logic in the visualization entries. For example, the visualization below has two <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> elements for a smart pointer type:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 When the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> member is <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, the condition of the first <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element resolves to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, so that form is displayed. When the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> member is not <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, the condition evaluates to <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, and the second <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> element is displayed.  
  
### IncludeView and ExcludeView attributes  
 These attributes specify elements that are to be displayed or not displayed in different views. For example, given the Natvis specification of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The simple view does not display the [size] and [capacity] items in the simple view. If we had used <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> items would be shown in the simple view rather than in the default view.  
  
 You can use the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> attributes on types as well as on individual members.  
  
###  \<a name="BKMK_DisplayString">\</a> DisplayString  
 A <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> element specifies the string to be shown as the value of the variable. It accepts arbitrary strings mixed with expressions. Everything inside curly braces is interpreted as an expression. For instance, a <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> entry like this:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Means that variables of type <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> are displayed like this:  
  
 ![Using a DisplayString element](../vs140/media/dbg_natvis_cpoint_displaystring.png "DBG_NATVIS_CPoint_DisplayString")  
  
 In the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> expression, <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, which are members of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, are inside curly braces and so their values are evaluated. The expression also shows how you can escape a curly brace by using double curly braces ( <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> ).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> element is the only element that accepts arbitrary strings and curly brace syntax. All other visualization elements accept only expressions that are evaluated by the debugger.  
  
###  \<a name="BKMK_StringView">\</a> StringView  
 The <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> element defines the expression whose value is going to be sent to the built-in text visualizer. For example, suppose we have the following visualization for the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> type:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object looks like:  
  
 ![CStringT DisplayString element](../vs140/media/dbg_natvis_displaystring_cstringt.png "DBG_NATVIS_DisplayString_CStringT")  
  
 The visualization displays a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object in a variable window like this:  
  
 Adding a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> element will indicate to the debugger that this value can be viewed by a text visualization:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Notice the magnifying glass icon shown next to the value below. Choosing the icon will launch the text visualizer which will display the string that <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> points to.  
  
 ![CStringT data with StringView visualizer](../vs140/media/dbg_natvis_stringview_cstringt.png "DBG_NATVIS_StringView_CStringT")  
  
> [!NOTE]
>  Note that the expression <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> includes a C++ format specifier <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> to display the value as a Unicode string. See [Format Specifiers in C++](../vs140/format-specifiers-in-c--.md) for more information.  
  
###  \<a name="BKMK_Expand">\</a> Expand  
 The <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> node is used to customize the children of the visualized type when the user expands it in the variable windows. It accepts a list of child nodes that define the child elements.  
  
 The <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> node is optional.  
  
-   If an <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> node is not specified in a visualization entry, Visual Studio’s default expansion rules are used.  
  
-   If an <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> node is specified with no child nodes under it, the type won’t be expandable in the debugger windows.  
  
####  \<a name="BKMK_Item_expansion">\</a> Item expansion  
 The <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> element is the most basic and the most common element to be used in an <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> node. <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> defines a single child element. For example, suppose that you have a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> class with <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> as its fields and the following visualization entry:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> type will look like this:  
  
 ![CRect with Item element expansion](../vs140/media/dbg_natvis_expand_item_crect1.png "DBG_NATVIS_Expand_Item_CRect1")  
  
 The expressions specified in <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> elements are evaluated and shown in the value column. The <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> node is automatically created by the debugger whenever a custom expansion is used. It is expanded in the screenshot above to show how the raw view of the object is different from its visualization. The Visual Studio default expansion creates a subtree for the base class and lists all the data members of the base class as children.  
  
> [!NOTE]
>  If the expression of the item element points to a complex type, the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> node itself is expandable.  
  
####  \<a name="BKMK_ArrayItems_expansion">\</a> ArrayItems expansion  
 Use the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> node to have the Visual Studio debugger interpret the type as an array and display its individual elements. The visualization for <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is a good example:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> shows its individual elements when expanded in the variable window:  
  
 ![std::vector using ArrayItems expansion](../vs140/media/dbg_natvis_expand_arrayitems_stdvector.png "DBG_NATVIS_Expand_ArrayItems_StdVector")  
  
 At a minimum, the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> node must have:  
  
1.  A <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> expression (which must evaluate to an integer) for the debugger to understand the length of the array  
  
2.  A <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> expression that should point to the first element (which must be a pointer of an element type that is not <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>).  
  
 The default value of the array lower bound is 0. The value can be overridden by using a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> element (examples can be found in the .natvis files shipped with Visual Studio).  
  
 You can now use the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> operator with an <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> expansion, for example <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>. The [] operator can be used with any visualization of a single-dimensional array that uses <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>, even if the type itself does not allow this operator (for example <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>).  
  
 Multi-dimensional arrays can also be specified. The debugger needs just a little bit more information to properly display child elements in that case:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> specifies whether the array is row-major or column-major order. <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> specifies the rank of the array. The <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> element accepts the implicit <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> parameter which it substitutes with the dimension index to find the length of the array in that dimension. For example, in the previous example, above the expression <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> should give the length of the 0th dimension, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> the 1st and so on.  
  
 Here’s how a two dimensional <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object looks in the debugger:  
  
 ![Two dimensional array with ArrayItems expansion](../vs140/media/dbg_natvis_expand_arrayitems_2d.png "DBG_NATVIS_Expand_ArrayItems_2D")  
  
####  \<a name="BKMK_IndexListItems_expansion">\</a> IndexListItems expansion  
 You can use the <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> expansion, only if the array elements are laid out contiguously in memory. The debugger gets to the next element by simply incrementing its pointer to the current element. To support cases where you need to manipulate the index to the value node, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> nodes can be used. Here’s a visualization using <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> node:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 You can now use the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> operator with an <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> expansion, for example <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> operator can be used with any visualization of a single-dimensional array that uses <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>, even if the type itself does not allow this operator (for example <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>).  
  
 The only difference between <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> is that the <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> expects the full expression to the i<sup>th\</sup> element with the implicit <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> parameter.  
  
####  \<a name="BKMK_LinkedListItems_expansion">\</a> LinkedListItems expansion  
 If the visualized type represents a linked list, the debugger can display its children by using a <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> node. Here’s the visualization for the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> type using this feature:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> element refers to the length of the list. <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> points to the first element, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> refers to the next element, and <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> refers to the value of the item.  
  
-   The <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> expressions are evaluated in the context of the linked list node element and not the parent list type. In the example above, <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> has a <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> class (found in <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>) that represents a node of the linked list. <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> are fields of that <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> class and not of <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> class.  
  
-   The <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> can be left empty or have <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> to refer to the linked list node itself.  
  
#### CustomListItems expansion  
 The <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> expansion allows you to write custom logic for traversing a data structure such as a hashtable. You should use <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> to visualize data structures in which everything you need to evaluate is expressible via C++ expressions, but don’t quite fit the mold for <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
  
 The visualizer for CAtlMap is an excellent example of where <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> is appropriate.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
####  \<a name="BKMK_TreeItems_expansion">\</a> TreeItems expansion  
 If the visualized type represents a tree, the debugger can walk the tree and display its children by using a <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> node. Here’s the visualization for the <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> type using this feature:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The syntax is very similar to the <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> node. <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> are evaluated under the context of the tree node class, and <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> can be left empty or have <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> to refer to the tree node itself.  
  
####  \<a name="BKMK_ExpandedItem_expansion">\</a> ExpandedItem expansion  
 The <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> element can be used to generate an aggregated child view by displaying properties of base classes or data members as if they were children of the visualized type. The specified expression is evaluated and the child nodes of the result are appended to the child list of the visualized type. For example, suppose we have a smart pointer type <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> which will typically be displayed as:  
  
 ![auto&#95;ptr&#60;vector&#60;int&#62;&#62; default expansion](../vs140/media/dbg_natvis_expand_expandeditem_default.png "DBG_NATVIS_Expand_ExpandedItem_Default")  
  
 To see the values of the vector, you have to drill down two levels in the variable window passing through _Myptr member. By adding an <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> element, you can eliminate the <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> variable from the hierarchy and directly view the vector elements::  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 ![auto&#95;ptr&#60;vector&#60;int&#62;&#62; ExpandedItem expansion](../vs140/media/dbg_natvis_expand_expandeditem_visualized.png "DBG_NATVIS_Expand_ExpandedItem_Visualized")  
  
 The example below shows how to aggregate properties from the base class in a derived class. Suppose the <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> class derives from <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>. Instead of repeating the properties that come from the base <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> class, the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> node allows those properties to be appended to the child list of the <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> class. The **nd** format specifier which turns off visualization matching for the derived class is necessary here. Otherwise, the expression <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> will cause the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> visualization to be applied again because the default visualization type matching rules consider it the most appropriate one. Using the **nd** format specifier instructs the debugger to use the base class visualization or the base class default expansion if the base class doesn’t have a visualization.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
####  \<a name="BKMK_Synthetic_Item_expansion">\</a> Synthetic Item expansion  
 Where the <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> element provides a flatter view of data by eliminating hierarchies, the <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> node does the opposite. It allows you to create an artificial child element (that is, a child element that is not a result of an expression). This child element can contain children elements of its own. In the following example, the visualization for the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> type uses a <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> node to show a diagnostic message to the user:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 ![Concurrency::Array with Sythentic element expansio](../vs140/media/dbg_natvis_expand_synthetic.png "DBG_NATVIS_Expand_Synthetic")  
  
###  \<a name="BKMK_HResult">\</a> HResult  
 The <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> element enables you to customize the information that is displayed for an HRESULT in debugger windows. The <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> element must contain the 32-bit value of the HRESULT that is to be customized. The <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> element contains the information that is displayed in the debugger.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
###  \<a name="BKMK_UIVisualizer">\</a> UIVisualizer  
 A <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> element registers a graphical visualizer plug-in with the debugger. A graphical visualizer plug-in creates a dialog box or another interface to display a variable or object in a manner that is appropriate to its data type. The visualizer plug-in must be authored as a [VSPackage](../vs140/vspackages.md) and needs to expose a service that can be consumed by the debugger. The .natvis file contains registration information for the plug-in such as its name, the GUID of the service exposed, and also the types it can visualize.  
  
 Here's an example of a UIVisualizer element:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> is identified by a <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> attribute pair. <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> is the GUID of the service exposed by the visualizer package, <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> is a unique identifier that can be used to differentiate visualizers if a service provides more than one visualizer. In the example above, the same visualizer service provides two visualizers.  
  
 The <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> attribute is what the users see as the name of the visualizer when they open the drop-down menu next to the magnifying glass icon in the debugger variable windows, for example:  
  
 ![UIVisualizer menu shortcut menu](../vs140/media/dbg_natvis_vectorvisualizer.png "DBG_NATVIS_VectorVisualizer")  
  
 Each type defined in the .natvis file must explicitly list the UI visualizers that can display them. The debugger matches the visualizer references in the type entries to match types with the registered visualizers. For example, the following type entry for <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> references the UIVisualizer in our example above.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 You can see an example of the UIVisualizer in the Image Watch extension used to view in-memory bitmaps: [ImageWatch](https://visualstudiogallery.msdn.microsoft.com/e682d542-7ef3-402c-b857-bbfba714f78d)  
  
### CustomVisualizer element  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> is an extensibility point that specifies a VSIX extension that you can write to control the visualization in code that runs in Visual Studio. For more information about writing VSIX extensions, see [Visual Studio SDK](../vs140/visual-studio-sdk.md). Writing a custom visualizer is a lot more work than writing an XML natvis definition, but you are free from constraints about what natvis supports or doesn’t support. Custom visualizers have access to the full set of debugger extensibility APIs, which can be used to query and modify the debuggee process or communicate with other parts of Visual Studio.  
  
 You can use the <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> attributes on CustomVisualizer elements.