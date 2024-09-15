<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <h1 align="center">Library</h1>
                <table border="3" align="center" >
                    <tr>
                        <th>ID жанра</th>
                        <th>Название жанра</th>
                    </tr>
                    <xsl:for-each select="genre/row">
                        <tr>
                            <td><xsl:value-of select="genreid"/></td>
                            <td><xsl:value-of select="genrename"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
				<table border="3" align="center" >
                    <tr>
                        <th>ID сотрудника</th>
                        <th>ID жанра</th>
                        <th>ФИО</th>
                    </tr>
                    <xsl:for-each select="employee/row">
                        <tr>
                            <td><xsl:value-of select="employeeid"/></td>
                            <td><xsl:value-of select="genreid"/></td>
                            <td><xsl:value-of select="fio"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
				<table border="3" align="center" >
                    <tr>
                        <th>ID книги</th>
						<th>ID жанра</th>
                        <th>Название</th>
                        <th>Автор</th>
                    </tr>
                    <xsl:for-each select="book/row">
                        <tr>
                            <td><xsl:value-of select="bookid"/></td>
                            <td><xsl:value-of select="genreid"/></td>
                            <td><xsl:value-of select="title"/></td>
							<td><xsl:value-of select="author"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>