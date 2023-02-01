# NOTE: This file is auto generated by OpenAPI Generator 6.3.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.ArrayTest do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :array_of_string,
    :array_array_of_integer,
    :array_array_of_model
  ]

  @type t :: %__MODULE__{
    :array_of_string => [String.t] | nil,
    :array_array_of_integer => [[integer()]] | nil,
    :array_array_of_model => [[OpenapiPetstore.Model.ReadOnlyFirst.t]] | nil
  }
end

defimpl Poison.Decoder, for: OpenapiPetstore.Model.ArrayTest do
  def decode(value, _options) do
    value
  end
end

