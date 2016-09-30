---
title: "Extending JavaScript IntelliSense"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "JavaScript, intellisense object"
  - "extending JavaScript IntelliSense"
  - "customizing JavaScript IntelliSense"
  - "JavaScript, extending IntelliSense"
  - "IntelliSense [JavaScript], extending"
ms.assetid: 004e1ab6-bd7a-4327-9e01-89b9be96ba2f
caps.latest.revision: 43
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extending JavaScript IntelliSense
The JavaScript IntelliSense extensibility feature enables you to customize IntelliSense results in the JavaScript editor for third-party libraries. This can improve the experience of developers who use these libraries.  
  
 The JavaScript language service provides IntelliSense features for third-party JavaScript libraries that are added to a project. For most libraries, statement completion is provided automatically by the language service. The following illustration shows an example of statement completion:  
  
 ![Example of statement completion](../vs140/media/js_intellisense_completion.png "js_intellisense_completion")  
  
 If your library includes descriptions of variables, functions, and objects in standard JavaScript comment tags (//), you automatically benefit, by default, from IntelliSense extensibility features, which provide descriptive information in a pop-up box that appears to the right of elements in a completion list, or when you type the opening parenthesis in a function call. The comments in the pop-up box contain the description of the member. The following example shows the pop-up box for a completion list.  
  
 ![Example of a Quick Info pop&#45;up box](../vs140/media/js_intellisense_quickinfo.png "js_intellisense_quickinfo")  
  
 To further improve the developer experience, you might want to provide type information to developers in the pop-up box. You can provide type information by using JavaScript [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md) instead of standard comment tags. You add XML Documentation Comments by using triple-slash comment tags (///) and a defined set of XML elements.  
  
 Alternatively, you can provide type information by using JavaScript IntelliSense extensibility. This feature enables you to customize IntelliSense results by creating JavaScript extensions and adding them to the script context. In the extension, which is a JavaScript file, you subscribe to events that are exposed by the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object of the language service. JavaScript IntelliSense extensibility is the preferred solution for libraries if a behavior pattern in the library prevents the JavaScript language service from providing the desired level of IntelliSense support, and if an alternative to declarative XML Documentation Comments is also needed. By customizing the IntelliSense results, you can create a first-class IntelliSense experience, regardless of any behavioral patterns that might restrict the language service's default capabilities. For more information, see [Statement Completion for Identifiers](../vs140/statement-completion-for-identifiers.md).  
  
## Adding an Extension to the Script Context  
 For an IntelliSense extension to be executed, it needs to be added to the current script context. The extension can be automatically added to the script context by the automatic discovery mechanism, or you can add the extension to the script context manually by using reference groups or the reference directive.  
  
 The automatic discovery mechanism enables the language service to automatically find extensions that follow the file naming convention *libraryname*.intellisense.js, and that are located in the same directory as the library to which the extension applies. For example, a valid extension for the jQuery library would be jQuery.intellisense.js. For more restrictive jQuery extensions, you can use file names such as jQuery-1.7.1.intellisense.js (a version-specific extension) or jQuery.ui.intellisense.js (an extension for a scoped jQuery library). The most restrictive version of the extension is used if more than one extension is found for a given library.  
  
 If you want to use the extension for all your JavaScript project files, you might instead choose to add the extension to a reference group. There are several types of reference groups, either those that include implicit references and those that include dedicated worker references. To add an extension, you typically need to add the file as an implicit reference group, either **Implicit (Windows)**, **Implicit (Web)**. Implicit references are in scope for every .js file opened in the Code Editor. When you use this method, you need to add both the extension and the file that the extension is supplementing.  
  
 Use the **IntelliSense** page of the **Options** dialog box to add an extension as a reference group. You can access the **IntelliSense** page by choosing **Tools**, **Options** on the menu bar, and then choosing **Text Editor**, **JavaScript**, **IntelliSense**, **References**. For more information about reference groups, see [JavaScript IntelliSense](../vs140/javascript-intellisense.md) and [Text Editor, JavaScript, IntelliSense](../vs140/options--text-editor--javascript--intellisense.md).  
  
 If you want to use the extension for a specific set of files, use a reference directive. When you use this method, you need to reference both the extension and the file the extension is supplementing. For information about using the reference directive, see [JavaScript IntelliSense](../vs140/javascript-intellisense.md).  
  
## Handling IntelliSense events  
 The extensibility feature enables you to customize IntelliSense results by subscribing to events such as the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> event of the language service <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. The following example shows a simple extension that's used by the language service to hide members that begin with an underscore from statement completion. This code is contained in underscorefilter.js and is in the \\\\*Visual Studio installation path*\JavaScript\References folder.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding code, the extension checks the [targetName](#TargetName) and [target](#Target) properties of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> event object to exclude objects such as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and to ensure that a valid statement completion list can be identified. If a completion list can be identified, the extension updates the statement completion [items](#Items) collection by filtering out members that begin with an underscore.  
  
 For additional examples, look in the \\\\*Visual Studio installation path*\JavaScript\References folder. The showPlainComments.js file in this folder provides examples of using other events to provide default IntelliSense support for standard JavaScript comment tags (//). Like underscorefilter.js, showPlainComments.js is already available as a working extension, and you can see the resulting IntelliSense information when using comment tags in your code for variables, functions, and objects. For additional examples, see [Code Examples](#CodeExamples).  
  
> [!WARNING]
>  If you modify the extension files included with Visual Studio, you may disable JavaScript IntelliSense or the feature supported by the extension.  
  
 In your extension code, you can create handlers for the following event types by using <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>:  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, which adds a handler for a statement completion event. Statement completion provides a list of members for a particular type that appears after you type a special character such as a period (.), or a list of identifiers that appears while you type or when you press CTRL + J. The handler receives an event object of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, which supports the following members: [items](#Items), [target](#Target), [targetName](#TargetName), and [scope](#Scope).  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, which adds a handler for IntelliSense Parameter Info. Parameter information gives you information about the number, names, and types of parameters required by a function. The handler receives an event object of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, which supports the following members: [target](#Target), [parentObject](#ParentObject), [functionComments](#FunctionComments), [functionHelp](#FunctionHelp).  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, which adds a handler for IntelliSense Quick Info. The Quick Info pop-up box shows the complete declaration for identifiers in your code. The handler receives an event object of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, which supports the following members: [completionItem](#CompletionItem), and [symbolHelp](#SymbolHelp).  
  
 For examples that show IntelliSense features such as statement completion, parameter information, and Quick Info, see [Using IntelliSense](../vs140/using-intellisense.md).  
  
> [!NOTE]
>  In JavaScript, Quick Info refers to the pop-up box that appears to the right of a completion list. You cannot manually invoke Quick Info.  
  
##  \<a name="intellisenseObject">\</a> intellisense Object  
 The following table shows the functions that are available for the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object is available only at design time.  
  
|Function|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Adds an event handler for an IntelliSense event.\<br />\<br /> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a string value. Valid values include <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.\<br />\<br /> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is an event handler function that receives an event object of one of the following types:\<br />\<br /> -   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, used for the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> event.\<br />-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, used for the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> event.\<br />-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, used for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> event.\<br />\<br /> For examples that use this function, see [Code Examples](#CodeExamples).|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Specifies documentation for an object by copying documentation comments from one object to another object.\<br />\<br /> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> specifies the object to which to copy the documentation.\<br />\<br /> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> specifies the object from which to copy the documentation.\<br />\<br /> For an example that shows how to use this function, see [Adding IntelliSense Annotations](#Annotations).|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Returns the comments for a specified function.\<br />\<br /> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> specifies the function for which comments are returned.\<br />\<br /> You can set the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> parameter by using <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.\<br />\<br /> The returned <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object includes the following members: <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. For more information, see the [functionComments](#FunctionComments) property.\<br />\<br /> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> can be called only from within one of the event handlers that are registered by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.\<br />\<br /> For an example that shows how to use this function, see \\\\*Visual Studio installation path*\JavaScript\References\showPlainComments.js.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Sends diagnostic messages to the Output window.\<br />\<br /> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is a string that contains the message.\<br />\<br /> For an example that shows how to use this function, see [Sending Messages to the Output window](#Logging).|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Returns a special null value for which the completion list is determined by the object passed in the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> parameter.\<br />\<br /> <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> determines the completion list for the returned value. <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> can be any type.\<br />\<br /> The null return value is treated as null at design-time, but the completion list for the return value is the same as the completion list for the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> parameter.\<br />\<br /> One use for this function is to provide IntelliSense for a return value when the return type is predictable at runtime, but the return value is <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> at design-time.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Instructs IntelliSense to use the provided definition function instead of the original func function when parameter help or **Go To Definition** is requested.\<br />\<br /> <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> specifies the target function.\<br />\<br /> <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> specifies the function to be used instead of the target function for parameter information and **Go To Definition**.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Sets the call context, or scope, for the specified function.\<br />\<br /> <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> specifies the function for which to set the scope.\<br />\<br /> <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is an object literal to which the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> keyword can refer to, which specifies the new scope for the member. You can include arguments to pass in this parameter, for example, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> provides behavior similar to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, except that it used only for design-time IntelliSense support. You can use <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to set the function scope if you need to simulate a call to code that is not otherwise reachable, so that when you call the function, the function call will include the correct scope and arguments.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Returns a special undefined value for which the completion list is determined by the object passed in the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> parameter.\<br />\<br /> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> determines the completion list for the returned value. <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> can be any type.\<br />\<br /> The undefined return value is treated as undefined at design-time, but the completion list for the return value is the same as the completion list for the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> parameter.\<br />\<br /> One use for this function is to provide IntelliSense for a return value when the return type is predictable at runtime, but the return value is undefined at design-time.|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Returns the Visual Studio version.|  
  
## Event Members  
 The following sections describe the members that are exposed in the event object for the following events: <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
###  \<a name="CompletionItem">\</a> completionItem Property  
 Returns the identifier, known as the completion item, for which a Quick Info pop-up box is requested. This property is available for the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> event object and for the [items](#Items) property of the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> event object.  
  
 Return value: <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object  
  
 Following are the members of the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object:  
  
-   <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. Read/write when used in the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> collection; otherwise, read-only. Returns a string that identifies the completion item.  
  
-   <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. Read/write when used in the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> collection; otherwise, read-only. Returns a string that represents the type of completion item. The possible values are method, field, property, parameter, variable, and reserved.  
  
-   <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Read/write when used in the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> collection; otherwise, read-only. Returns a string that represents an icon that's displayed in the completion list. The possible values for <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> use the following format: vs:*glyphType*, where *glyphType* corresponds to the language-independent members in the \<xref:Microsoft.VisualStudio.Language.Intellisense.StandardGlyphGroup*> enumeration. For example, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is one possible value for <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is not set, the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> property determines the default icon.  
  
-   <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. Read-only. Returns the parent object.  
  
-   <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. Read-only. Returns an object that represents the value of the completion item.  
  
-   <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>. Read-only. Returns a string that contains the comments that are above the field or variable.  
  
-   <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. Read-only. Returns the scope of the completion item. The possible values are global, local, parameter, and member.  
  
###  \<a name="Items">\</a> items Property  
 Gets or sets the array of statement completion items. Each element in the array is a [completionItem](#CompletionItem) object. The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> property is available for the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> event object.  
  
 Return value: array  
  
###  \<a name="FunctionComments">\</a> functionComments Property  
 Returns the comments for the function. This property is available for the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> event object.  
  
 Return value: <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object  
  
 Following are the members of the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object:  
  
-   <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. Returns the comments above the function.  
  
-   <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>. Returns the comments inside the function, typically in VSDoc format.  
  
-   <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. Returns an array representing comments for each parameter in the function. The members of the array include:  
  
    -   <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. Returns a string representing the parameter name.  
  
    -   <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>. Returns a string that contains the parameter comment.  
  
###  \<a name="FunctionHelp">\</a> functionHelp Property  
 Returns the Help for the function. This property is available for the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> event object.  
  
 Return value: <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object  
  
 Following are the members of the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object:  
  
-   <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. Read/write. Returns a string that contains the function name.  
  
-   <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>. Read/write. Gets or sets the array of function signatures. Each element in the array is a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object. Some <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> properties, such as <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, correspond to common [XML Documentation Comment](../vs140/xml-documentation-comments--javascript-.md) attributes.  
  
     The members of the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object include:  
  
    -   <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>. Read/write. Returns a string that describes the function.  
  
    -   <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. Read/write. Returns a string identifier that contains localization information about the function.  
  
    -   <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>. Read/write. Returns a string that contains the Help keyword.  
  
    -   <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the file that contains the member ID.  
  
    -   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the member ID of the function.  
  
    -   <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>. Read/write. Gets or sets the array of parameters for the function. Each element in the parameters array is a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object that has properties that correspond to the following attributes of the [\<param>](../vs140/-param---javascript-.md) element:  
  
        -   <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the parameter name.  
  
        -   <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the parameter type.  
  
        -   <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>. Read/write. If the type is <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>, returns a string that represents the type of the elements in the array.  
  
        -   <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. Read/write. Returns a string that describes the parameter.  
  
        -   <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>. Read/write. Returns a string identifier that contains localization information about the function.  
  
        -   <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>. Read/write. Returns a string that indicates whether the parameter is optional. <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> indicates that the parameter is optional; <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> indicates that it isn't.  
  
    -   <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>. Read/write. Gets or sets a return value object with properties that correspond to the following attributes of the [<returns>](../vs140/-returns---javascript-.md) element:  
  
        -   <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the return type.  
  
        -   <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>. Read/write. If the type is <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, returns a string that represents the type of the elements in the array.  
  
        -   <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>. Read/write. Returns a string that describes the return value.  
  
        -   <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. Read/write. Returns a string identifier that contains localization information about the function.  
  
        -   <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>. Read/write. Returns a string that contains the Help keyword.  
  
        -   <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the file that contains the member ID.  
  
        -   <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the member ID of the function.  
  
###  \<a name="ParentObject">\</a> parentObject Property  
 Returns the parent object of a member function. For example, for <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> returns the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object. This property is available for the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> event object.  
  
 Return value: object  
  
###  \<a name="Target">\</a> target Property  
 Returns an object that represents the item to the left of the trigger character, which is a period (.). For functions, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> returns the function for which Parameter Info is requested. This property is available for the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> event objects.  
  
 Return value: object  
  
###  \<a name="TargetName">\</a> targetName Property  
 Returns a string that represents the target. For example, for "this.", <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> returns "this". For "A.B" (when the cursor is after "B"), <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> returns "B". This property is available for the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> event object.  
  
 Return value: string  
  
###  \<a name="SymbolHelp">\</a> symbolHelp Property  
 Returns the completion item for which a Quick Info pop-up box is requested. This property is available for the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> event object.  
  
 Return value: <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object.  
  
 Some properties of the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> object, such as <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>, correspond to common [XML Documentation Comment](../vs140/xml-documentation-comments--javascript-.md) attributes.  
  
 Following are the members of the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> object:  
  
-   <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>. Read/write. Returns a string that contains the identifier name.  
  
-   <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the symbol type. Possible values include Unknown, Boolean, Number, String, Object, Function, Array, Date, and Regex.  
  
-   <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>. Read/write. Returns a string that contains the type name to display. If <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> isn't set, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> is used.  
  
-   <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>. Read/write. If the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, returns a string that represents the type of the elements in the array.  
  
-   <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the scope of the symbol. Possible values include global, local, parameter, and member.  
  
-   <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>. Read/write. Returns a string that contains a description of the symbol.  
  
-   <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>. Read/write. Returns a string identifier that contains localization information about the symbol.  
  
-   <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. Read/write. Returns a string that contains the Help keyword.  
  
-   <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the file that contains the member ID.  
  
-   <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. Read/write. Returns a string that represents the member ID of the symbol.  
  
-   <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>. Read/write. Returns a [functionHelp object](#FunctionHelp), which might contain information when the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> is Function.  
  
###  \<a name="Scope">\</a> scope Property  
 Returns the completion scope of the event. The possible values for the completion scope are global and members. This property is available for the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> event object.  
  
 Return value: string  
  
## Debugging IntelliSense extensions  
 You can't debug extensions, but you can use the [logMessage](#intellisenseObject) function to send information to the Visual Studio Output window. For an example that shows how to use this function, see [Logging Messages](#Logging) later in this topic. For <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> to work, at least one event handler must be registered in an extension.  
  
##  \<a name="CodeExamples">\</a> Code Examples  
 This section includes code examples that show how to use the IntelliSense extensibility APIs. There are also other ways to use these APIs. For additional examples, see the following files in the \\\\*Visual Studio installation path*\JavaScript\References folder. These are working examples used by the JavaScript language service.  
  
-   underscoreFilter.js. This code hides private members from IntelliSense. It includes event handlers for the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> event.  
  
-   showPlainComments.js. This code provides IntelliSense support for standard comments. It includes event handlers for the <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> events.  
  
###  \<a name="Annotations">\</a> Adding IntelliSense Annotations  
 The following procedure shows how to provide IntelliSense documentation support for a third-party library without modifying the library directly. To do this, you can use <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> in an extension.  
  
 For this example to work, you need the following JavaScript files in your project:  
  
-   demoLib.js, which is a project file that represents a third-party library.  
  
-   demoLib.intellisense.js, which is the IntelliSense extension. This file doesn't need to be included in the project, but it does need to be in the same folder as exampleLib.js.  
  
-   appCode.js, which is a project file that represents app code.  
  
##### To add an IntelliSense annotation  
  
1.  Add the following code to demoLib.js.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Add the following code to demoLib.intellisense.js.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Add the following reference directive as the first line in appCode.js. The path used here indicates that the JavaScript files are in the same folder.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  In appCode.js, type the following code. You'll see the XML documentation comments in the extension displayed as IntelliSense Parameter Info.  
  
     ![Example showing the use of intellisense.annotate](../vs140/media/js_intellisense_annotate_paraminfo.png "js_intellisense_annotate_paraminfo")  
  
5.  In appCode.js, type the following code. While you type, you'll see the standard comments in the extension displayed as IntelliSense Quick Info.  
  
     ![Example showing the use of intellisense.annotate](../vs140/media/js_intellisense_annotations.png "js_intellisense_annotations")  
  
###  \<a name="Logging">\</a> Sending Messages to the Output Window  
 The following procedure shows how to send messages to the Output window. You can send messages to help debug IntelliSense extensions.  
  
 For this example to work, you need the following JavaScript files in your project:  
  
-   exampleLib.js, which is a project file that represents a third-party library.  
  
-   exampleLib.intellisense.js, which is the IntelliSense extension. This file doesn't need to be included in the project, but it does need to be in the same folder as exampleLib.js.  
  
-   appCode.js, which is a project file that represents app code.  
  
##### To send a message to the Output window  
  
1.  Add the following code to exampleLib.js.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  Add the following code to exampleLib.intellisense.js.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Add the following reference directive as the first line in appCode.js. The path used here indicates that the JavaScript files are in the same folder.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
4.  In the Output window, choose **JavaScript Language Service** in the **Show output from** list. (To view the Output window, select **Output** from the View menu.)  
  
5.  In appCode.js, type the following code. While you type, the Output window shows messages from the language service. The first message in the Output window indicates that statement completion for the current scope has been requested.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     Following is a partial view of the output you should see.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
6.  Choose the **Clear All** button in the Output window.  
  
7.  Type the following code. The first message in the output window indicates that a member list has been requested.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
     Following is a partial view of the output you should see:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
###  \<a name="Icons">\</a> Changing the IntelliSense icons  
 The following procedure shows how to change the icons displayed by IntelliSense by default. This might be useful when you provide IntelliSense information about library-specific concepts such as namespaces, classes, interfaces, and enumerations.  
  
 For available icon values, see \<xref:Microsoft.VisualStudio.Language.Intellisense.StandardGlyphGroup*>.  
  
 For this example to work, you need the following JavaScript files in your project:  
  
-   exampleLib.js, which is a project file that represens a third-party library.  
  
-   exampleLib.intellisense.js, which is the IntelliSense extension. This file doesn't need to be included in the project, but it does need to be in the same folder as exampleLib.js.  
  
-   appCode.js, which is a project file that represents app code.  
  
##### To change the icons  
  
1.  Add the following code to exampleLib.js.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
2.  Add the following code to exampleLib.intellisense.js.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
3.  Add the following reference directive as the first line in appCode.js. The path used here indicates that the JavaScript files are in the same folder.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
4.  In appCode.js, type the following code. While you type, you'll see that the icon for the namespace has changed to "{}", as is used in C#.  
  
     ![Example showing the use of glyph property](../vs140/media/js_intellisense_glyph_namespace.png "js_intellisense_glyph_namespace")  
  
5.  In appCode.js, type the following code. While you type, you'll see a new enumeration icon for the Enum1 member, and a new class icon for the SomeClass1 member.  
  
     ![Example showing use of the glyph property](../vs140/media/js_intellisense_glyph_class_enum.png "js_intellisense_glyph_class_enum")  
  
###  \<a name="Overriding">\</a> Avoiding run-time effects on IntelliSense results  
 The JavaScript language service runs code to dynamically provide IntelliSense information. As a result, run-time behavior can occasionally interfere with desired results. The following procedure shows how to override IntelliSense results when run-time behavior results in incorrect IntelliSense.  
  
 For this example to work, you need the following JavaScript files in your project:  
  
-   exampleLib.js, which is a project file that represents a third-party library.  
  
-   exampleLib.intellisense.js, which is the IntelliSense extension. This file doesn't need to be included in the project, but it does need to be in the same folder as exampleLib.js.  
  
-   appCode.js, which is a project file that represents app code.  
  
##### To avoid run-time effects on IntelliSense results  
  
1.  Add the following code to exampleLib.js.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
     In the preceding code, the wrapped function ignores initial calls, based on the value of <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, and doesn't return results.  
  
2.  Add the following reference directive as the first line in appCode.js. The path used here indicates that the JavaScript files are in the same folder.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
3.  In appCode.js, type the following code. The identifier list appears instead of IntelliSense because the wrapped function is never called, which means that the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> function doesn't return any results.  
  
     ![Example of overriding intellisense results](../vs140/media/js_intellisense_override.png "js_intellisense_override")  
  
4.  Add the following code to exampleLib.intellisense.js. This will change the design-time behavior so that IntelliSense is shown for the wrapped function, as expected.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
5.  In appCode.js, test the results by typing the same code that you typed previously. This time, IntelliSense provides the desired information.  
  
     ![Example of overriding IntelliSense results](../vs140/media/js_intellisense_override_fixed.png "js_intellisense_override_fixed")  
  
## See Also  
 [JavaScript IntelliSense](../vs140/javascript-intellisense.md)   
 [Statement Completion for Identifiers](../vs140/statement-completion-for-identifiers.md)