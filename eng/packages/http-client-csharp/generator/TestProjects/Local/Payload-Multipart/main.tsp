import "@typespec/http";
import "@typespec/spector";

using Http;
using Spector;

@doc("Test for multipart")
@scenarioService("/multipart")
namespace Payload.MultiPart;


model MultiPartRequest {
  id: string;
  profileImage: bytes;
}

model Address {
  city: string;
}

model FileSpecificContentType extends File {
  filename: string;
  contentType: "image/jpg";
}

model FileWithHttpPartSpecificContentTypeRequest {
  profileImage: HttpPart<FileSpecificContentType>;
}

model FileRequiredMetaData extends File {
  filename: string;
  contentType: string;
}

model FileWithHttpPartRequiredContentTypeRequest {
  profileImage: HttpPart<FileRequiredMetaData>;
}

model FileOptionalContentType extends File {
  filename: string;
}

model FileWithHttpPartOptionalContentTypeRequest {
  profileImage: HttpPart<FileOptionalContentType>;
}

model ComplexHttpPartsModelRequest {
  id: HttpPart<string>;
  address: HttpPart<Address>;
  profileImage: HttpPart<FileRequiredMetaData>;
  previousAddresses: HttpPart<Address[]>;
  pictures: HttpPart<FileRequiredMetaData>[];
}

model ComplexPartsRequest {
  id: string;
  address: Address;
  profileImage: bytes;
  pictures: bytes[];
}

model JsonPartRequest {
  address: Address;
  profileImage: bytes;
}

model BinaryArrayPartsRequest {
  id: string;
  pictures: bytes[];
}

model MultiBinaryPartsRequest {
  profileImage: bytes;
  picture?: bytes;
}

@route("/form-data")
namespace FormData {
  @doc("Test content-type: multipart/form-data")
  @post
  @route("/mixed-parts")
  op basic(
    @header contentType: "multipart/form-data",
    @body body: MultiPartRequest,
  ): NoContentResponse;
}
