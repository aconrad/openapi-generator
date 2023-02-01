# NOTE: This file is auto generated by OpenAPI Generator 6.3.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.ApiResponse do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :code,
    :type,
    :message
  ]

  @type t :: %__MODULE__{
    :code => integer() | nil,
    :type => String.t | nil,
    :message => String.t | nil
  }
end

defimpl Poison.Decoder, for: OpenapiPetstore.Model.ApiResponse do
  def decode(value, _options) do
    value
  end
end

