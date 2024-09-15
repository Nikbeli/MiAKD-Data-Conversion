<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <head>
                <style>
                    /* CSS стили */
                    table {
                        border-collapse: collapse;
                        width: 100%;
                    }
                    th, td {
                        text-align: left;
                        padding: 8px;
                    }
                    th {
                        background-color: #004890;
                        color: #FFFFFF;
                        font-weight: bold;
                        border-radius: 5px;
                    }
                    tr:nth-child(even) {
                        background-color: #f2f2f2;
                    }
                    tr:hover {
                        background-color: #dcdcdc;
                    }
                    h2 {
                        text-align: center;
                        font-size: 24px;
                        font-weight: bold;
                        color: #004890;
                        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
                        border: 1px solid #004890;
                        border-radius: 5px;
                        padding: 10px;
                    }
                </style>
            </head>
            <body>
                <h2>Ульяновский Государственный Технический Университет</h2>
                <table>
                    <tr>
                        <th>Имя</th>
                        <th>Фамилия</th>
                        <th>Курс</th>
                    </tr>
                    <xsl:for-each select="ulgtu/student">
                        <tr>
                            <td><xsl:value-of select="name"/></td>
                            <td><xsl:value-of select="surname"/></td>
                            <td><xsl:value-of select="course"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>