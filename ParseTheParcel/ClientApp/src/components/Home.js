import React, { Component } from 'react';
import ParseTheParcel from './ParseTheParcel/ParseTheParcel';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <ParseTheParcel></ParseTheParcel>
    );
  }
}
