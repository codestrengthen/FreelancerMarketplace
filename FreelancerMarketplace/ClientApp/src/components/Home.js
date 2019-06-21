import React, { Component } from 'react';
import Category from './Category/Category';

export class Home extends Component {
  static displayName = Home.name;

  render () {
     return (
         <Category />
    );
  }
}
