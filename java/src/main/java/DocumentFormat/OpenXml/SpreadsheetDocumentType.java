package DocumentFormat.OpenXml;

/**
 * Defines SpreadsheetDocumentType - type of SpreadsheetDocument.
 */
public enum SpreadsheetDocumentType {
    /** Excel Workbook (*.xlsx). */
    Workbook,

    /** Excel Template (*.xltx). */
    Template,

    /** Excel Macro-Enabled Workbook (*.xlsm). */
    MacroEnabledWorkbook,

    /** Excel Macro-Enabled Template (*.xltm). */
    MacroEnabledTemplate,

    /** Excel Add-In (*.xlam). */
    AddIn
}
