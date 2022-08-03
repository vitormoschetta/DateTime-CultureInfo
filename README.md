Os JsonSerializertipos Utf8JsonReaderUtf8JsonWriter, e JsonElement tipos analisam e gravam DateTime e gravam representações DateTimeOffset de texto de acordo com o perfil estendido do formato ISO 8601-1:2019; por exemplo, 2019-07-26T16:59:57-05:00.

Para desserializar outros formatos de Data, poderíamos usar uma sobrecarga nos métodos de desserialização, ou desserializar como string e fazer o parser para o tipo desejado.


### Referências

<https://docs.microsoft.com/pt-br/dotnet/standard/datetime/system-text-json-support>