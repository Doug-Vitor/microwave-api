using System.Collections;
using System.Collections.Generic;

public class ErrorResponseDTO
{
  public int StatusCode { get; set; }
  public string Error { get; set; }
  public IDictionary<string, string[]> Errors { get; set; }

  public ErrorResponseDTO(int statusCode, string error)
    => (StatusCode, Error) = (statusCode, error);
}