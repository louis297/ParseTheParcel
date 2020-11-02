import React, {useState} from 'react'
import { Container, Form, FormGroup, Input, Label } from 'reactstrap';
import REST from '../../lib/REST';
import ParseResult from './ParseResult';

export default function ParseTheParcel() {
  const [length, setLength] = useState(0);
  const [breadth, setBreadth] = useState(0);
  const [height, setHeight] = useState(0);
  const [weight, setWeight] = useState(0);
  const [showResult, setShowResult] = useState(false);
  const [resultContent, setResultContent] = useState("");

  const onClickHandler = async (event) => {
    // VERY important, without persist event will be re-use and set to null in async function
    event.persist();
    event.preventDefault();
    console.log([length, breadth, height, weight]);

    REST.get({
      url: 'ParseTheParcel/parsetheparcel',
      params: {
        length: length,
        breadth: breadth,
        height: height,
        weight: weight
      }
    }).then(res => {
      if(res.data.isSuccess){
        setResultContent(
          <p className="text-success">
          {`The parcel costs $${res.data.price}.`}
          </p>
          )
      } else {
        setResultContent(
          <p className="text-danger">
            {res.data.message}
          </p>
          )
      }
      setShowResult(true)
    }).catch(res => {
      console.log(res.data)
    })
  }

  return (
    <Container>
      <h1>Parse The Parcel</h1>
        <Form id='ParseTheParcelForm' onSubmit={onClickHandler}>
          <FormGroup>
            <Label>Length in mm:</Label>
            <Input type="number" value={length} onChange={e => {setLength(e.target.value)}} />
            
          </FormGroup>
          <FormGroup>
            <Label>Breadth in mm:</Label>
            <Input type="number" value={breadth} onChange={e => {setBreadth(e.target.value)}} />
          </FormGroup>
          <FormGroup>
            <Label>Height in mm:</Label>              
            <Input type="number" value={height} onChange={e => {setHeight(e.target.value)}} />
          </FormGroup>
          <FormGroup>
            <Label>Weight in gram:</Label>
            <Input type="number" value={weight} onChange={e => {setWeight(e.target.value)}} />
          </FormGroup>
          <FormGroup>
            <Input type="submit" value="Submit" />
          </FormGroup>
        </Form>
      <div className={showResult?"hidden":""}>
        <h3>{resultContent}</h3>
      </div>
    </Container>
  )
}
